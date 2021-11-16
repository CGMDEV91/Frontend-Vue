<template>
  <div>
    <ListadoIncidenciasTareas :tipo="tipo" :datos="tareas" :ruta="/tareasEmpleado/"></ListadoIncidenciasTareas>
  </div>
</template>

<script>
import axios from 'axios';
import ListadoIncidenciasTareas from '../components/ListadoIncidenciasTareas.vue'

export default {
  name: 'Tareas',
  components:{
    ListadoIncidenciasTareas
  },
  created: function (){
    this.read('/Tarea');
  },
  data:function () {
      return{
          tareas: {},
          fechaMod: null,
          error: null,
          tipo: "Tareas"
      }
  },
  methods: {
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
