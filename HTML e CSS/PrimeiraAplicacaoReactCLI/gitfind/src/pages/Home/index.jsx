import {useState, useEffect} from 'react'
import { Header } from '../../components/Header';
import imagemGit from '../../assets/ImagemGit1.png'
import './styles.css'
import List from '../../components/List'

function App() {
  const [user, setUser] = useState('');
  const [currentUser, setCurrentUser] = useState(null);
  const [repos, setRepos] = useState(null);
  const [error, setError] = useState(null); // potenciais erros

  const handleGetData = async () => {
    try {
      const userData = await fetch(`https://api.github.com/users/${user}`);
      const newUser = await userData.json();

      if (newUser) { // Check if newUser exists to avoid errors
        const { avatar_url, name, bio, login } = newUser;
        setCurrentUser({ avatar_url, name, bio, login });
        console.log(newUser);

        const reposData = await fetch(`https://api.github.com/users/${user}/repos`);
        const newRepos = await reposData.json();

        if (newUser === ""){
        handleGetData.useState(null)
        repos.useState(null)
        }

        if (newRepos.length) {
          setRepos(newRepos);
        } else {
          console.log('Usuário não tem repositórios.'); // se o usuário não tiver repositórios
        }
      } else {
        setError('Erro: Usuário não encontrado.'); // se o usuário não for encontrado
      }
    } catch (error) {
      console.error('Error ao buscar dados:', error);
    }
  };

  return (
    <div className="App">
      <Header />
      <div className="Conteúdo">
        <img src={imagemGit} className="imagemGit" alt="imagemGit" />
      </div>

      <div className="div">
        <div>
          <input
            name="usuario"
            value={user}
            onChange={(event) => setUser(event.target.value)}
            placeholder="@username"
          />
          <button onClick={handleGetData}>Busca</button>

          <div>
            {error && <p>Erro: {error}</p>} {/* Exibir mensagem de erro, se presente */}
            {currentUser && ( // Verifique se currentUser existe
              <>
                <div className="perfil">
                  <img
                    src={currentUser.avatar_url}
                    className="profile"
                    alt="imagem"
                  />
                  <div>
                    <h3>{currentUser.name}</h3>
                    <span>@{currentUser.login}</span>
                    <p>{currentUser.bio}</p>
                  </div>
                </div>
                <hr />
              </>
            )}

            {repos?.length && ( // faz o mapeamento da lista
              <div>
                <h4 className="repositorios">Repositórios</h4>
                {repos.map((repo) => (
                  <List key={repo.id} title={repo.name} description={repo.description} />
                ))}
              </div>
            )}
          </div>
        </div>
      </div>
    </div>
  );
}

export default App;