const urlPath = '../js/data/empleados.json'

export const getEmpleados = async (callback) => {
    await fetch(urlPath)
        .then( (response) => response.json())
        .then( (data) => callback(data))
        .catch( (error) => console.log('Error al obtener los datos de los empleados: '+ error))
}