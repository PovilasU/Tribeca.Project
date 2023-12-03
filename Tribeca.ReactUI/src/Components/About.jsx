export default function About() {
  return (
    <div className="module">
      <img className="img-me center" src="/povilas.jpg" alt="image" />
      <h2 className="center about-h2">Description</h2>
      <p className="tac1">
        A web app that fetches Cliens, offices, employees, emp star sign, emp
        bio, dev magic to english text
      </p>
      <h2>Technologies used</h2>
      <ul>
        <li>ReactJs</li>
        <li>React Router</li>
        <li>Fetch API</li>
      </ul>
      <div className="contact-links jcse">
        <a
          href="https://www.linkedin.com/in/povilas-urbonas-0a6a53a4/"
          target="_blank"
          rel="noopener noreferrer"
        >
          LinkedIn
        </a>
        <a
          href="https://github.com/PovilasU/Tribeca.Project"
          target="_blank"
          rel="noopener noreferrer"
        >
          GitHub
        </a>
      </div>
    </div>
  );
}
