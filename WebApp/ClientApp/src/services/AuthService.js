import axios from "axios";

const API_URL = "auth/";

const register = (firstName, lastName, email, password) => {
  debugger;
  return axios.post(API_URL + "register", {
    firstName,
    lastName,
    email,
    password,
  });
};

const login = (email, password) => {
  return axios
    .post(API_URL + "login", {
      email,
      password,
    })
    .then((response) => {
      console.log("====================================");
      console.log(response.data);
      console.log("====================================");
      if (response.data.token) {
        localStorage.setItem("user", JSON.stringify(response.data));
      }

      return response.data;
    })
    .catch((error) => {
      console.error("axios: ", error.message);
    });
};

const update = (email, passwordToCheck, password) => {
  return axios
    .post(API_URL + "update", {
      email,
      passwordToCheck,
      password,
    })
    .then((response) => {
      console.log("====================================");
      console.log(response.data);
      console.log("====================================");
    })
    .catch((error) => {
      console.error("axios: ", error.message);
    });
};

const logout = () => {
  localStorage.removeItem("user");
};

export default {
  register,
  login,
  logout,
  update,
};
