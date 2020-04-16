<template>
  <div>
    <b-jumbotron header="The Hillside Lodge" lead="A lodge overlooking a beautiful valley.">
      <b-button variant="primary" href="#">Book a room now!</b-button>
    </b-jumbotron>
  </div>
</template>

<script>
export default {
  name: "HomePage",
  props: {
    test: {
      default: "test",
      type: String
    }
  }
};
</script>

<style scoped>
h1 {
  font-family: "Franklin Gothic Medium", "Arial Narrow", Arial, sans-serif;
}
</style>