<template>
  <div id="app">
    <div class="container-fluid">
      <div id="nav">
        <button class="btn btn-success ml-2 col-md-2 mb-2 md-0"><router-link class="text-light text-decoration-none" to="/">Inicio</router-link></button>
        <button class="btn btn-primary ml-2 col-md-2 mb-2 md-0"><router-link class="text-light text-decoration-none" to="/empresas">Empresas</router-link></button>
        <button class="btn btn-primary ml-2 col-md-2 mb-2 md-0"><router-link class="text-light text-decoration-none" to="/empleados">Empleados</router-link></button>
        <button class="btn btn-primary ml-2 col-md-2 mb-2 md-0"><router-link class="text-light text-decoration-none" to="/incidencias">Incidencias</router-link></button>
        <button class="btn btn-primary ml-2 col-md-2 mb-2 md-0"><router-link class="text-light text-decoration-none" to="/tareas">Tareas</router-link></button>
      </div>
    <router-view/>
    </div>
  </div>
</template>

<script>


export default {
  name: 'App',
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}

#nav {
  padding: 30px;
}

#nav a {
  font-weight: bold;
  color: #2c3e50;
}

</style>
