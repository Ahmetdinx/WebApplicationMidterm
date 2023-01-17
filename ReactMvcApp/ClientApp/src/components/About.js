import { Card } from "react-bootstrap";
import MelihImage from "../assets/melihshtyn.JPG";
import AhmetImage from "../assets/ahmedinx.jpg";

const About = (props) => {
  return (
    <div class="container">
      <Card
        style={{
          width: "80%",
          justifyContent: "center",
          alignItems: "center",
          textAlign: "left",
          fontSize: 18,
        }}
      >
        <Card.Title style={{ fontSize: 24, fontWeight: "bold" }}>
          About Us
        </Card.Title>
        <Card.Text style={{ textAlign: "center", fontSize: 20 }}>
          We are a group of student that looking for some solutions to industry
          problems. As we grow up, we will go deep in our job to make our
          business more sophisticated. In this project we were look into some
          Cyber Security issues.{" "}
          <span style={{ fontStyle: "italic" }}>Mittre Att&cks</span> are common
          choice to show this to our colleagues. For that happen, we used two of{" "}
          <span style={{ fontStyle: "italic" }}>
            Mittre Att&ck: Network Service Discovery, Access Token
            Impersonation.
          </span>
        </Card.Text>
        <Card.Text>
          <span style={{ fontStyle: "italic" }}>
            Network Service Discovery:
          </span>{" "}
          In short, this tool provides us an observation to services in victims
          computer via ip address.
          <br />
          <span style={{ fontStyle: "italic" }}>
            Access Toke Impersonation:
          </span>{" "}
          Shortly, some softwares can extract access tokens in victims browser
          and using it provides them having access to their accounts.
        </Card.Text>
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
          <Card.Img variant="top" src={AhmetImage} />
          <Card.Title>Ahmet Eren Dinç</Card.Title>
          <Card.Text>School Number: 190706040</Card.Text>
          <Card.Text>
            License Education: Maltepe University - Software Engineering(EN.){" "}
            <br />
            Associate Degree: Istanbul University - Graphical Design(TR.)
          </Card.Text>
          <Card.Text>Work Experience: Logischool</Card.Text>
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
          <Card.Text>School Number: 190706023</Card.Text>
          <Card.Text>
            License Education: Maltepe University - Software Engineering(EN.)
          </Card.Text>
          <Card.Text>Work Experience: GDSC-Maltepe</Card.Text>
        </Card.Body>
      </Card>
    </div>
  );
};

export default About;
