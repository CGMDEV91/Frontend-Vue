<template>
  <div>
    <h1>Detalle de Incidencia</h1>
    <div class="container">
    
        <div class="row justify-content-center">
          <div class="table-responsive">
            <table class="table table-striped">
            <thead>
                <tr>
                <th scope="col">Tipo</th>
                <th scope="col">Responsable</th>
                <th scope="col">Descripcion</th>
                <th scope="col">Estado</th>
                <th scope="col">Fecha de Registro</th>
                <th scope="col">Acciones</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="(dato) in datos" :key="dato.Id">
                <td>{{dato.Tipo}}</td>
                <td>{{dato.Empleado}}</td>
                <td>{{dato.Descripcion}}</td>
                <td>{{estadoTarea(dato.Completada)}}</td>
                <td>{{formatFecha(dato.Fecha)}} </td>
                <td>
                  <button @click="editar" class="btn btn-primary mb-2 mb-md-0">Editar</button>
                  <button @click="eliminarIncidencia(dato.Id)" class="btn btn-danger ml-3 ">Eliminar</button>
                </td>
                </tr>
            </tbody>
            </table>
          </div>
        </div>
        <div class="row justify-content-center mt-2">
          <div v-if="visible" class="alert alert-danger col-6" role="alert">
            Incidencia Eliminada!
          </div>
        </div>
    </div>
  </div>
</template>

<script>
import axios from 'axios';

export default {
  name: 'IncidenciasAsignadas',
  props: {
      tipo: String,
      datos: Object
  },
  data: function(){
    return{
      visible: false
    }
  },methods:{
    eliminarIncidencia: function(id) {
      axios.delete(this.$APIURL + '/Incidencia/' + id)
      .then(response => {
        console.log(response.data);
        this.visible = true;
        setTimeout(() => this.$router.push('/incidencias'), 2000);
      })
      .catch(e => {
        this.error = e;
        console.log(e);
      });
    },
  }
  
}
</script>
