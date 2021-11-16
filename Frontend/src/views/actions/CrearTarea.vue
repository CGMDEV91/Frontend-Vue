<template>
    <div class="container-fluid">
        <h1>Crear Tarea</h1>
        <div class="row justify-content-center mt-5">
            <form class="col-sm-12 col-md-6">
              <div class="form-group row">
                    <label for="empleado" class="col-4 col-form-label">Empleado</label>
                    <div class="col-6">
                        <select id="empleado" v-model="empleado" class="form-control">
                        <option v-for="(empleado) in empleados" :value="empleado" :key="empleado.Id">{{empleado.Nombre}}</option>
                    </select> 
                    </div>
                </div>
                <div class="form-group row">
                    <label for="estado" class="col-4 col-form-label">Estado</label>
                    <div class="col-6">
                        <select id="estado" v-model="estado" class="form-control">
                          <option selected>Pendiente</option>
                          <option>Finalizada</option>
                        </select>
                    </div>
                </div>
                <div class="form-group row">
                  <label for="descripcion" class="col-4 col-form-label">Descripcion</label>
                  <div class="col-6">
                    <textarea class="form-control" id="descripcion" v-model="descripcion" rows="3"></textarea>
                  </div>
                </div>
                <div class="form-group row">
                    <label for="fecha" class="col-4 col-form-label">Fecha</label>
                    <div class="col-6">
                    <input type="date" class="form-control" id="fecha" v-model="fecha" placeholder="Aquí el nombre...">
                    </div>
                </div>
                <button class="btn btn-primary" @click="CrearTarea">Crear</button>
            </form>
        </div>
    </div>
</template>

<script>
import axios from 'axios';

export default {
    name: 'CrearTarea',
    components:{
  },
  created: function (){
    this.read('/Empleado');
  },
  data: function() {
    return {
      empleado: '',
      fecha: '',
      descripcion: '',
      estado: '',
      completada: false,
      tarea: {},
      url: "/Tarea/",
      empleados: {}

    }
  },
  methods: {
    read: function(url){
      console.log(this.$APIURL + url)
      axios.get(this.$APIURL + url)
      .then(response => {
        this.empleados = response.data;
        console.log(this.empleados);
      })
      .catch(e => {
        this.error = e;
        console.log(e);
      })
    },
    CrearTarea: function(){
      if(this.estado == 'Completada'){
        this.completada = true;
      }
      this.tarea = {
        "Descripcion": this.descripcion,
        "Completada": this.completada,
        "Fecha": this.fecha,
        "EmpleadoId": 2
      }
      this.create(this.url);
    },
    create: function(url){
      axios.post(this.$APIURL + url ,this.tarea).
      then((response)=>{
        console.log(response.data);
        this.$router.push('/tareas')
      })
      .catch(error => {
        console.log(error.response);
      })
    },
  }
}
</script>

<style>

</style>