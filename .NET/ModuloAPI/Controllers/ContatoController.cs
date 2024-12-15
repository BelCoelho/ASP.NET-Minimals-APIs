using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModuloAPI.Context;
using ModuloAPI.Entities;

namespace ModuloAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ContatoController : ControllerBase
    {
        private readonly AgendaContext _context;

        public ContatoController(AgendaContext context)
        {
            _context = context;
        }

        [HttpPost]
        //Estamos enviando o método
        public IActionResult Create(Contato contato)
        //Contato contato são as informações armazendas em Json
        {
            //Endpoint de criação de dados para enviar para a API
            _context.Add(contato);
            //adiciona os itens pedidos em Contato (nome, telefone e ativo)
            _context.SaveChanges();
            //Salva as informações recem adicionadas
            return Ok(contato);
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            //Endpoint para pesquisar o Id
            var contato = _context.Contatos.Find(id);
            //O ponto contato é o DbSet, e ele vai tentar encontrar o id inserido
            //Se o Id existir ele retorna os valores que pertencem á aquele Id

            if (contato == null)
                return NotFound();
                //Faz a verificação se o id for nulo 

            return Ok(contato);
        }

        [HttpGet("ObterPorNome")]
        public IActionResult ObterPorNome(string nome)
        {
            //Endpoint para pesquisar pelo nome (texto digitado)
            var contatos = _context.Contatos.Where(x => x.Nome.Contains(nome));
                                                  // => significa link
            return Ok(contatos);
            //Retorna a lista com os itens que tem o texto pesquisado
        }

        [HttpPut("{id}")]//insere dados
        public IActionResult Atualizar(int id, Contato contato)
        //O metodo atualizar vai receber um Id e o json do contato que vai ser atualizado
        {
            //Endpoint de Update
            var contatoBanco = _context.Contatos.Find(id);
            //contatoBanco é o contato que está no banco de dados
            //Faz a busca do contato pelo id

            if (contatoBanco == null)
                return NotFound();
                //Se a informação for nula nada será atualizada

            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Ativo = contato.Ativo;
            //Passa as informações armazenadads no contatoBanco (o que está no banco) 
            //para o contato que está no corpo da requisição
            //Aquilo que está no banco será atualizado com aquilo que vai ser inserido
            //Ou seja, se o contato for válido o nome, o telefone e o ativo serão atualizados

            _context.Contatos.Update(contatoBanco);
            _context.SaveChanges();
            //Atualiza os dados que foram atualizados acima e salva eles

            return Ok(contatoBanco);
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            //Endpoint de Deletar
            var contatoBanco = _context.Contatos.Find(id);
            //Faz a pesquisa pelo Id

            if (contatoBanco == null)
                return NotFound();

            _context.Contatos.Remove(contatoBanco);
            _context.SaveChanges();
            //Se válido, o id pesquisado será deletado

            return NoContent();
            //Se o item é deletado não há o que deletar
        }
    }
}