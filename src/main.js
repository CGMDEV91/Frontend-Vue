import Vue from 'vue'
import App from './App.vue'
import router from './router'
import { BootstrapVue, IconsPlugin } from 'bootstrap-vue'
import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap-vue/dist/bootstrap-vue.css'

Vue.use(BootstrapVue)
Vue.use(IconsPlugin)

Vue.config.productionTip = false;

Vue.prototype.$APIURL= 'http://localhost:32110/api';

Vue.mixin({
  methods: {
    formatFecha: function(fecha){ 
        var day = fecha.substring(8,10);
        var month = fecha.substring(5,7);
        var year = fecha.substring(0,4);
        this.fechaMod = day + '/' + month + '/' + year;
        return this.fechaMod;
    },
    estadoTarea: function(estado){
      var tarea = estado ? "Completada" : "Pendiente";
      return tarea;
    },
    editar: function(){
      alert("Editar")
    }
  },
});

new Vue({
  router,
  render: h => h(App)
}).$mount('#app')
