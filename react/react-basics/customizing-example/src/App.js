import avatar from './avatar.webp'

function Logo(props) {
  const userPic = <img src={avatar}></img>
  return userPic
}

function App() {
  return (
    <div>
      <h1>Hello World!</h1>
      <Logo />
    </div>
  );
}

export default App;
