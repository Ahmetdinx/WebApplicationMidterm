import React, { useState, useLayoutEffect } from "react";
import AttackDetailService from "../services/AttackDetailService";
import { Card, Button, InputGroup, Dropdown } from "react-bootstrap";

const AttackList = () => {
  const [contents, setContent] = useState([]);
  const [attackType, setAttackType] = useState("");

  const onSearchClickHandler = () => {
    AttackDetailService.getAllByEmailAndAttackType(
      localStorage.getItem("email"),
      attackType
    ).then((response) => {
      setContent(response.data.data);
      console.log("====================================");
      console.log("Attack Type: ", contents);
      console.log("====================================");
    });
  };

  useLayoutEffect(() => {
    AttackDetailService.getUserBoard(localStorage.getItem("email")).then(
      (response) => {
        setContent(response.data.data);
        console.log("Response data: ", response.data);
      },
      (error) => {
        const _content =
          (error.response && error.response.data) ||
          error.message ||
          error.toString();
        console.log("Error: ", error.message);
        setContent(_content);
      }
    );
    console.log("Content: ", contents);
  }, []);

  return (
    <div className="container">
      <header className="jumbotron">
        <InputGroup>
          <Dropdown className="d-inline mx-2">
            <Dropdown.Toggle id="dropdown-autoclose-true">
              {attackType.length > 0 ? attackType : "Attack Types"}
            </Dropdown.Toggle>
            <Dropdown.Menu>
              <Dropdown.Item onClick={() => setAttackType("nmap")}>
                nmap
              </Dropdown.Item>
              <Dropdown.Item
                onClick={() => setAttackType("Token Impersonation")}
              >
                Token Impersonation
              </Dropdown.Item>
            </Dropdown.Menu>
          </Dropdown>
          <Button onClick={onSearchClickHandler} color="success">
            Search
          </Button>
        </InputGroup>
        {contents.length > 0 ? (
          contents.map((content, index) => {
            return (
              <Card>
                <Card.Body>
                  <Card.Text scope="row"># {content.id}</Card.Text>
                  <Card.Text scope="row">
                    Attack Description: {content.attackDescription}
                  </Card.Text>
                  <Card.Text>Date: {content.date}</Card.Text>
                  <Card.Text>User id : {content.userId}</Card.Text>
                  <Card.Text>Attack Type: {content.attackType}</Card.Text>
                </Card.Body>
              </Card>
            );
          })
        ) : (
          <Card>
            <Card.Body>
              <Card.Title>There are not an attack to your account</Card.Title>
              <Card.Text>You are safe for now!</Card.Text>
            </Card.Body>
          </Card>
        )}
      </header>
    </div>
  );
};

export default AttackList;
