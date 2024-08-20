import Header from "./components/Header/Header.jsx";
import CoreConceptBox from "./components/CoreConcepts/CoreConceptBox.jsx";
import Examples from "./components/Examples/Examples.jsx";

function App() {
  return (
    <>
      <Header />
      <main>
        <CoreConceptBox />
        <Examples />
      </main>
    </>
  );
}

export default App;
