<template>
  <div>
    <div class="container">
      <h1>Empresas</h1>
        <div class="row justify-content-center">
          <button class="btn btn-primary mb-3 col-6"><router-link class="text-light text-decoration-none" to="/crearEmpresas">Crear Empresa</router-link></button>
          <div class="table-responsive">
            <table class="table table-striped">
              <thead>
                <tr>
                  <th scope="col">Nombre</th>
                </tr>
              </thead>
              <tbody>
                <tr v-for="(empresa) in empresas" :key="empresa.Id">
                  <td>{{empresa.Nombre}}</td>
                </tr>
              </tbody>
            </table>
          </div>
      </div>
    </div>
  </div>
</template>

<script>
import axios from 'axios';

export default {
  name: 'Empresas',
  components:{

  },
  created: function (){
    this.read('/Empresa');
  },
  data:function () {
      return{
          empresas: {},
            error: null
      }
  },
  methods: {
    read: function(url){
      axios.get(this.$APIURL + url)
      .then(response => {
        this.empresas = response.data;
        console.log(this.empresas);
      })
      .catch(e => {
        this.error = e;
        console.log(e);
      })
    }
  }
}
</script>
