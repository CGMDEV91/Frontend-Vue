<template>
  <div>
    <h1>{{tipo}}</h1>
    <div class="container">
    <button class="btn btn-primary col-6"><router-link class="text-light text-decoration-none" :to="{ path: '/crear' + tipo}">Crear {{tipo.substring(0,tipo.length-1)}}</router-link></button>
      <div class="row justify-content-center mt-3">
      <div class="table-responsive">
        <table class="table table-striped">
          <thead>
            <tr>
              <th scope="col">#</th>
              <th scope="col">Responsable</th>
              <th scope="col">Descripcion</th>
              <th scope="col">{{tipo}} Asignadas</th>
            </tr>
          </thead>
          <tbody>
            <tr v-for="(dato) in datos" :key="dato.Id">
              <th scope="row">{{dato.Id}}</th>
              <td>{{dato.Empleado}}</td>
              <td>{{dato.Descripcion}}</td>
              <td>
                <button class="btn btn-warning shadow">
                  <router-link class="text-light font-weight-bold text-decoration-none" :to="{ path: ruta + dato.Id}">
                    Ver Detalle 
                  </router-link>
                </button>
              </td>
            </tr>
          </tbody>
        </table>
        </div>
      </div>
    </div>
  </div>
</template>

<script>

export default {
  name: 'ListadoIncidenciasTareas',
  props: {
      datos: Object,
      tipo: String,
      ruta: String
  },
}
</script>
