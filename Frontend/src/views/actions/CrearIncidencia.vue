<template>
    <div class="container-fluid">
        <h1>Crear Incidencia</h1>
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
                    <label for="tipo" class="col-4  col-form-label">Tipo de Avería</label>
                    <div class="col-6">
                    <input type="text" class="form-control" v-model="tipo" id="tipo" placeholder="...">
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
                <button class="btn btn-primary" @click="CrearIncidencia">Crear</button>
            </form>
        </div>
        <div class="row justify-content-center mt-2">
          <div v-if="visible" class="alert alert-success col-md-6" role="alert">
              Incidencia Creada!
          </div>
        </div>
    </div>
</template>

<script>
import axios from 'axios';

export default {
    name: 'CrearIncidencia',
    components:{
  },
  created: function (){
    this.read('/Empleado/');
  },
  data: function() {
    return {
      empleado: '',
      tipo: '',
      fecha: '',
      descripcion: '',
      estado: '',
      completada: false,
      incidencia: {},
      url: "/Incidencia/",
      empleados: {},
      visible: false

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
    CrearIncidencia: function(){
      if(this.estado == 'Completada'){
        this.completada = true;
      }
      this.incidencia = {
        "Tipo": this.tipo,
        "Descripcion": this.descripcion,
        "Completada": this.completada,
        "Fecha": this.fecha,
        "EmpleadoId": 2
      }
      this.create(this.url);
    },
    create: function(url){
      axios.post(this.$APIURL + url ,this.incidencia).
      then((response)=>{
        console.log(response.data);
        this.visible = true;
        setTimeout(() => this.$router.push('/incidencias'), 2000);
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