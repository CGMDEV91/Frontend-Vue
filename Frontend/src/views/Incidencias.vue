<template>
  <div>
        <ListadoIncidenciasTareas :tipo="tipo" :datos="incidencias" :ruta="/incidenciaEmpleado/"></ListadoIncidenciasTareas>
  </div>
</template>

<script>
import axios from 'axios';
import ListadoIncidenciasTareas from '../components/ListadoIncidenciasTareas.vue'

export default {
  name: 'Incidencias',
  components:{
    ListadoIncidenciasTareas
  },
  created: function (){
    this.read(this.url);
  },
  data:function () {
      return{
          url: "/Incidencia",
          incidencias: {},
          error: null,
          tipo: "Incidencias"
      }
  },
  methods: {
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
