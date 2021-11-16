<template>
  <div>
    <IncidenciasAsignadas :tipo="tipo" :datos="incidencias" ></IncidenciasAsignadas>
    <button class="btn btn-success ml-2"><router-link class="text-light text-decoration-none" to="/Incidencias">Volver</router-link></button>
  </div>
</template>

<script>
import axios from 'axios';
import IncidenciasAsignadas from '../components/IncidenciasAsignadas.vue'

export default {
  name: 'IncidenciasEmpleado',
  components:{
      IncidenciasAsignadas
  },
  created: function (){
    this.id_empleado=this.$route.params.id;
    this.read(this.url + this.id_empleado);
  },
  data:function () {
      return{
            id_empleado: null,
            url: "/Incidencia/",
            incidencias: {},
            error: null,
            tipo: "Incidencias"
      }
  },
  methods: {
      mostrarIncidencias(empleadoId){
          this.read('/' + empleadoId);

      },
    read: function(url){
      axios.get(this.$APIURL + url)
      .then(response => {
        this.incidencias = response.data;
        console.log(this.incidencias);
      })
      .catch(e => {
        this.error = e;
        console.log(e);
      })
    }
  }
}
</script>
