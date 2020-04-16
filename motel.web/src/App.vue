<template>
  <div id="app">
    <HomePage v-bind:test="test" />
    <div>
      <b-jumbotron header="The Hillside Lodge" lead="A lodge overlooking a beautiful valley.">
        <b-button variant="primary" href="#">Book a room now!</b-button>
      </b-jumbotron>
    </div>
  </div>
</template>

<script>
import HomePage from "./pages/HomePage";

export default {
  name: "App",
  components: {
    HomePage
  },
  data() {
    return {
      test: "my data"
    };
  }
};
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
