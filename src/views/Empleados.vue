<template>
  <div>
    <div class="container">
      <h1>Empleados</h1>
        <div class="row justify-content-center">
          <button class="btn btn-primary mb-3 col-6"><router-link class="text-light text-decoration-none" to="/crearEmpleados">Crear Empleado</router-link></button>
          <div class="table-responsive">
            <table class="table table-striped">
              <thead>
                <tr>
                  <th scope="col">#</th>
                  <th scope="col">Nombre</th>
                  <th scope="col">Empresa</th>
                </tr>
              </thead>
              <tbody>
                <tr v-for="(empleado) in empleados" :key="empleado.Id">
                  <th scope="row">{{empleado.Id}}</th>
                  <td>{{empleado.Nombre}}</td>
                  <td>{{empleado.Empresa}}</td>
                </tr>
              </tbody>
            </table>
          </div>
      </div>
    </div>
  </div>
</template>

<script>
import axios from 'axios';

export default {
  name: 'Empleados',
  components:{

  },
  created: function (){
    this.read('/Empleado');
  },
  data:function () {
      return{
          empleados: {},
            error: null
      }
  },
  methods: {
    read: function(url){
      axios.get(this.$APIURL + url)
      .then(response => {
        this.empleados = response.data;
        console.log(this.empleados);
      })
      .catch(e => {
        this.error = e;
        console.log(e);
      })
    }
  }
}
</script>
