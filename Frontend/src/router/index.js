import Vue from 'vue'
import VueRouter from 'vue-router'
import Home from '../views/Home.vue'

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home
  },
  {
    path: '/about',
    name: 'About',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../views/About.vue')
  },
  {
    path: '/empresas',
    name: 'Empresas',
    component: () => import(/* webpackChunkName: "about" */ '../views/Empresas.vue')
  },
  {
    path: '/empleados',
    name: 'Empleados',
    component: () => import(/* webpackChunkName: "about" */ '../views/Empleados.vue')
  },
  {
    path: '/incidencias',
    name: 'Incidencias',
    component: () => import(/* webpackChunkName: "about" */ '../views/Incidencias.vue')
  },
  {
    path: '/incidenciaEmpleado/:id',
    name: 'IncidenciaEmpleado',
    component: () => import(/* webpackChunkName: "about" */ '../views/IncidenciaEmpleado.vue')
  },
  {
    path: '/tareas',
    name: 'Tareas',
    component: () => import(/* webpackChunkName: "about" */ '../views/Tareas.vue')
  },
  {
    path: '/tareasEmpleado/:id',
    name: 'TareasEmpleado',
    component: () => import(/* webpackChunkName: "about" */ '../views/TareasEmpleado.vue')
  },
  {
    path: '/crearEmpleados/',
    name: 'CrearEmpleado',
    component: () => import(/* webpackChunkName: "about" */ '../views/actions/CrearEmpleado.vue')
  },
  {
    path: '/crearEmpresas/',
    name: 'CrearEmpresa',
    component: () => import(/* webpackChunkName: "about" */ '../views/actions/CrearEmpresa.vue')
  },
  {
    path: '/crearTareas/',
    name: 'CrearTarea',
    component: () => import(/* webpackChunkName: "about" */ '../views/actions/CrearTarea.vue')
  },
  {
    path: '/crearIncidencias/',
    name: 'CrearIncidencia',
    component: () => import(/* webpackChunkName: "about" */ '../views/actions/CrearIncidencia.vue')
  },
]

const router = new VueRouter({
  routes
})

export default router
