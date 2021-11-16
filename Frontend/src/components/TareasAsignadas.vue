<template>
  <div>
    <h1>Detalle de Tarea</h1>
    <div class="container">
        <div class="row justify-content-center">
          <div class="table-responsive">
            <table class="table table-striped">
            <thead>
                <tr>
                <th scope="col">#</th>
                <th scope="col">Responsable</th>
                <th scope="col">Descripcion</th>
                <th scope="col">Estado</th>
                <th scope="col">Fecha de Registro</th>
                <th scope="col">Acciones</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="(dato) in datos" :key="dato.Id">
                <th scope="row">{{dato.id}}</th>
                <td>{{dato.Empleado}}</td>
                <td>{{dato.Descripcion}}</td>
                <td>{{estadoTarea(dato.Completada)}}</td>
                <td>{{formatFecha(dato.Fecha)}} </td>
                <td>
                  <button @click="editar" class="btn btn-primary mb-2 mb-md-0">Editar</button>
                  <button @click="eliminarTarea(dato.Id)" class="btn btn-danger ml-3">Eliminar</button>
                </td>
                </tr>
            </tbody>
            </table>
          </div>
        </div>
        <div v-if="visible" class="alert alert-danger" role="alert">
            Tarea Eliminada!
        </div>
    </div>
  </div>
</template>

<script>
import axios from 'axios';

export default {
  name: 'TareasAsignadas',
  props: {
      tipo: String,
      datos: Object
  },
  data: function(){
    return{
      visible: false
    }
  },methods:{
    eliminarTarea: function(id) {
      axios.delete(this.$APIURL + '/Tarea/' + id)
      .then(response => {
        console.log(response.data);
        this.visible = true;
        setTimeout(() => this.$router.push('/tareas'), 2000);
      })
      .catch(e => {
        this.error = e;
        console.log(e);
      });
    },
  }
  
}
</script>
