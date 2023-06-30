const url = 'https://svct.cartasur.com.ar/api/dummy';


export const GetStatus = () => {
    fetch(url)
    .then((response) => response.text())
    .then((data) => {
        const statusElement = document.getElementById('status');
        statusElement.textContent = data;
    })
    .catch((error) => {
        const statusElement = document.getElementById('status');
        statusElement.textContent = 'Error al obtener el estado del servicio';
        console.log('Error al consumir el servicio: ' + error);
    });
};