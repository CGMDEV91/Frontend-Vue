<template>
  <div>
    <TareasAsignadas :tipo="tipo" :datos="tareas"></TareasAsignadas>
    <button class="btn btn-success ml-2"><router-link class="text-light text-decoration-none" to="/Tareas">Volver</router-link></button>
  </div>
</template>

<script>
import axios from 'axios';
import TareasAsignadas from '../components/TareasAsignadas.vue'

export default {
  name: 'TareasEmpleado',
  components:{
      TareasAsignadas,
  },
  created: function (){
    this.id_empleado=this.$route.params.id;
    this.read(this.url + this.id_empleado);
  },
  data:function () {
      return{
          id_empleado: null,
          url: "/Tarea/",
          tareas: {},
          error: null,
          tipo: "Tareas"
      }
  },
  methods: {
      mostrarIncidencias(empleadoId){
          this.read('/' + empleadoId);

      },
    read: function(url){
      axios.get(this.$APIURL + url)
      .then(response => {
        this.tareas = response.data;
        console.log(this.tareas);
      })
      .catch(e => {
        this.error = e;
        console.log(e);
      })
    }
  }
}
</script>
