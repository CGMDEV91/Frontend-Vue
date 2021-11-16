<template>
    <div class="container-fluid">
        <h1>Crear Empresa</h1>
        <div class="row justify-content-center mt-5">
            <form class="col-sm-12 col-md-6">
                <div class="form-group row">
                    <label for="Nombre" class="col-4 col-form-label">Nombre Empresa</label>
                    <div class="col-6">
                    <input type="text" class="form-control" id="Nombre" v-model="nombre" placeholder="Aquí el nombre...">
                    </div>
                </div>
                
                <button @click="CrearEmpresa" class="btn btn-primary">Crear</button>
            </form>
        </div>
    </div>
</template>

<script>
import axios from 'axios';

export default {

    name: 'CrearEmpresa',
    components:{
  },
  data: function(){
      return {
          nombre: '',
          url: '/Empresa/'
      }
  },
   methods: {
    CrearEmpresa: function(){
      this.create(this.url);
    },
    create: function(url){
      axios.post(this.$APIURL + url ,{
        Nombre: this.nombre
      }).
      then((response)=>{
        console.log(response.data);
        this.$router.push('/empresas')
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