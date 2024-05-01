import { useEffect, useState } from 'react';
import { saveAs } from 'file-saver';

import './App.css';

function App() {
  const [context, setContext] = useState([]);
  const [image, setImage] = useState([]);
  const [isPrivacyHidden, setIsPrivacyHiden] = useState(false);

  const url = "http://188.166.203.164";

  function downloadImage(url, filename) {
    fetch(url, {mode: 'no-cors'})
      .then(response => response.blob())
      .then(blob => {
        saveAs(blob, filename);
      })
      .catch(error => {
        console.error('Error downloading image:', error);
      });
  }

  function acceptTermsOfUse() {
    fetch("http://188.166.203.164/static/test.json")
      .then((res) => res.json())
      .then((json) => {
        setImage(json.images)
        setIsPrivacyHiden(true);
      });
  }

  useEffect(() => {
    fetch("http://188.166.203.164/static/test.json")
      .then((res) => res.json())
      .then((json) => {
        setContext(json.terms_of_use.paragraphs)
      });
  }, [])

  return (
    <div className="App">
      <div className='container'>
        <div className={`container-privacy ${isPrivacyHidden ? 'hidden' : ''}`}>
          {context.map((item) =>
            <p>{item.content}</p>
          )}
          <button onClick={() => acceptTermsOfUse()}>Принять</button>

        </div>
        <div className='container-image'>
          <div className='card'>
            {image.map((img) =>
              <div key={img.image_url}>
                <a download onClick={() => downloadImage(url + img.image_url, img.image_name)}>
                  <img src={url + img.image_url}></img>
                </a>
              </div>
            )}
          </div>
        </div>
      </div>
    </div>
  );
}

export default App;
