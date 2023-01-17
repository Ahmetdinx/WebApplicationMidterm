import { Card } from "react-bootstrap";
import MelihImage from "../assets/melihshtyn.JPG";
import AhmetImage from "../assets/ahmedinx.jpg";

const Contact = (props) => {
  return (
    <div class="container">
      <Card
        style={{
          width: "36rem",
          justifyContent: "center",
          alignItems: "center",
          textAlign: "left",
        }}
      >
        <Card.Body>
          <Card.Img variant="top" src={AhmetImage} />
          <Card.Title>Ahmet Eren Dinç</Card.Title>
          <Card.Text>Phone Number: +905303965134</Card.Text>
          <Card.Text>E-mail: dincahmet87@gmail.com</Card.Text>
          <Card.Text>
            Linkedin:{" "}
            <a href="https://www.linkedin.com/in/ahmeterendinc/">
              Ahmet Eren Dinç - Linkedin
            </a>
          </Card.Text>
          <Card.Text>
            GitHub:{" "}
            <a href="https://github.com/Ahmetdinx">Ahmet Eren Dinç - GitHub</a>
          </Card.Text>
        </Card.Body>
      </Card>

      <Card
        style={{
          width: "36rem",
          justifyContent: "center",
          alignItems: "center",
          textAlign: "left",
        }}
      >
        <Card.Body>
          <Card.Img src={MelihImage} />
          <Card.Title>Melih Sahtiyan</Card.Title>
          <Card.Text>Phone Number: +905369335520</Card.Text>
          <Card.Text>E-mail: melihsahtiyan@gmail.com</Card.Text>
          <Card.Text>
            Linkedin:{" "}
            <a href="https://www.linkedin.com/in/melihsahtiyan/">
              Melih Sahtiyan - Linkedin
            </a>
          </Card.Text>
          <Card.Text>
            GitHub:{" "}
            <a href="https://github.com/melihsahtiyan">
              Melih Sahtiyan - GitHub
            </a>
          </Card.Text>
        </Card.Body>
      </Card>
    </div>
  );
};

export default Contact;
