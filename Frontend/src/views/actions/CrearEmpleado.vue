<template>
    <div class="container-fluid">
        <h1>Crear Empleado</h1>
        <div class="row justify-content-center mt-5">
            <form class="col-sm-12 col-md-6">
                <div class="form-group row">
                    <label for="Nombre" class="col-4 col-form-label">Nombre Empleado</label>
                    <div class="col-6">
                    <input type="text" class="form-control" id="Nombre" v-model="nombre" placeholder="Aquí el nombre...">
                    </div>
                </div>
                <div class="form-group row">
                    <label for="inputEmpresa" class="col-4 col-form-label">Empresa</label>
                    <div class="col-6">
                        <select id="inputEmpresa" v-model="empresa" class="form-control">
                        <option v-for="(empresa) in empresas" :key="empresa.Id">{{empresa.Nombre}}</option>
                    </select>
                    </div>
                </div>
                <button class="btn btn-primary" @click="CrearEmpleado">Crear</button>
            </form>
        </div>
        <div class="row justify-content-center mt-2">
          <div v-if="visible" class="alert alert-success col-md-6" role="alert">
              Empleado Creado!
          </div>
        </div>
    </div>
</template>

<script>
import axios from 'axios';

export default {
    name: 'CrearEmpleado',
    components:{
  },
  created: function (){
    this.read('/Empresa');
  },
  data: function(){
      return {
          nombre: '',
          empresa: '',
          url: '/Empleado/',
          empresas: {},
          visible: false
      }
  },
   methods: {
     read: function(url){
      axios.get(this.$APIURL + url)
      .then(response => {
        this.empresas = response.data;
      })
      .catch(e => {
        this.error = e;
        console.log(e);
      })
    },
    CrearEmpleado: function(){
      this.create(this.url);
    },
    create: function(url){
      axios.post(this.$APIURL + url ,{
        "Nombre":this.nombre,
        "EmpresaId": 1
      }).
      then((response)=>{
        console.log(response.data);
        this.visible = true;
        setTimeout(() => this.$router.push('/empleados'), 2000);
      })
      .catch(error => {
        console.log(error.response);
      })
    }
  }
}
</script>

<style>

</style>