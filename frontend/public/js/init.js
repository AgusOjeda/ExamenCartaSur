import {EmpleadosListaRender} from "./container/dashboard.js"
import { GetStatus } from "./services/EstadoServicioAPI.js";
import { NuevoEmpleado } from "./services/EmpleadosService.js";
window.onload = () => {
    ModalInit()
    GetStatus()
    NuevoEmpleado()
    EmpleadosListaRender()
}

const ModalInit = () => {
    const openModalButton = document.getElementById('openModal');
    const modal = document.getElementById('modal');
    const closeButton = document.getElementsByClassName('close')[0];

    openModalButton.addEventListener('click', () => {
      modal.style.display = 'block';
    });

    closeButton.addEventListener('click', () => {
      modal.style.display = 'none';
    });

    window.addEventListener('click', (event) => {
      if (event.target === modal) {
        modal.style.display = 'none';
      }
    });
}