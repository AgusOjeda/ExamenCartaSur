import { FilaEmpleado } from "../components/FilaEmpleado.js"
import { getEmpleados} from "./EmpleadoAPI.js"

let empleados = []

export const EmpleadosInformacion = async () => {
    await getEmpleados((data) => {
        empleados = data
        EmpleadosInformacionRender(data)}
    )
    ContarEmpleadosActivos()
    ContarEmpleadosInActivos()
}

const EmpleadosInformacionRender = async (data) => {
    data.forEach((empleado) => {
        const fila = FilaEmpleado(empleado)
        document.getElementById('empleadosLista').innerHTML += fila
    })
    
}

export const NuevoEmpleado = () => {
    const form = document.getElementById('formNuevoEmpleado')
    form.addEventListener('submit', (e) => {
        e.preventDefault()
        const empleado = {
            Nombre: document.getElementById('nombre').value,
            Apellido: document.getElementById('apellido').value,
            Estado: document.getElementById('estado').value
        }
        addEmpleado(empleado)
        Actualizar()
        form.reset()
    })
}

const Actualizar = () => {
    document.getElementById('empleadosLista').innerHTML = ''
    EmpleadosInformacionRender(empleados)
    ContarEmpleadosActivos()
    ContarEmpleadosInActivos()
}

const addEmpleado = (empleado) => empleados.push(empleado)



const ContarEmpleadosActivos = () => {
    let empleadosActivos = empleados.filter((empleado) => empleado.Estado === "Activo")
    let empleadosActivosContador = document.getElementById('empleadosActivos')
    empleadosActivosContador.innerHTML = empleadosActivos.length
}

const ContarEmpleadosInActivos = () => {
    let empleadosInactivos = empleados.filter((empleado) => empleado.Estado === "Inactivo")
    let empleadosInactivosContador = document.getElementById('empleadoInactivos')
    empleadosInactivosContador.innerHTML = empleadosInactivos.length
}
