# Universidad Católica del Uruguay
<img src="https://ucu.edu.uy/sites/all/themes/univer/logo.png"> 

## Facultad de Ingeniería y Tecnologías
### Programación II

## Template para entrega de ejercicios.

### Introducción
El siguiente repositorio fue creado con el objetivo de 
ayudarte en la organización de las entregas de tus ejercicios
prácticos. La solución contenida en este repositorio se compone de tres tipos de proyectos:

1. Consola
2. Biblioteca de clases
3. Test (NUnit)

### Estructura
La solución se estructura de la siguiente manera.

    .
    ├── assets  (Imagénes o multimedia)
    ├── docs    (Documentación del proyecto)
    ├── README.md   (Información general del proyecto)
    ├── src         
    │   ├── Library (Proyecto de biblioteca de clases)
    │   │   ├── Car.cs
    │   │   └── Library.csproj
    │   ├── Program (Proyecto de consola)
    │   │   ├── Program.cs
    │   │   └── Program.csproj
    │   └── test
    │       └── Test.Library (proyecto de Test Nunit)
    │           ├── CarTest.cs
    │           └── Test.Library.csproj
    └── TemplateEjercicio.sln (Archivo de solución)


### Correctitud
La calidad y correctitud de tu código es muy importante, por tal motivo hemos configurado dentro del template un pequeño archivo el cual ejecuta varias tareas, dentro de las cuales se verifica si tu programa compila y tus casos de pruebas se ejecutan exitosamente.

### Uso

1. Para utilizar este repositorio, como entrega de ejercicio has click en el botón 

    ![Use this template](./assets/uses-1.png)
2. En la siguiente pantalla debes de selecionar tu cuenta de github del combo de **owner**
    ![Use this template](./assets/uses-2.png)

3. Nombrar el repositorio

    ![Use this template](./assets/uses-3.png)

4. Crearlo como un repositorio público

    ![Use this template](./assets/uses-4.png)

5. Finalmente hacer click en el botón

    ![Use this template](./assets/uses-5.png)

6. Y ya tenemos nuestro repositorio listo para ser utilizado.

    ![Use this template](./assets/uses-6.png)

7. Es importante verificar la correcta compilación y ejecución de los test de nuestro proyecto. Para relizar este chequeo podemos ver un tick de color verde en el identificador del último commit realizado.

    ![Use this template](./assets/uses-7.png)
    ![Use this template](./assets/uses-8.png)

    si hacemos click sobre este tick podemos ver un popup el cual nos muestra el resultado de las tareas que se realizaron y en **"Details"**, podemos examinar que tareas se ejecutaron.

    ![Use this template](./assets/uses-9.png)
    ![Use this template](./assets/uses-10.png)

### Comandos

Para compilar nuestra solucion basta con pararnos en la raiz del proyecto y ejecutar

```
dotnet build
```
![Use this template](./assets/uses-11.png)


Para ejecutar nuestros casos de pruebas nos pararnos en la raiz del proyecto y ejecutamos
```
dotnet test
```
![Use this template](./assets/uses-12.png)

Para ejecutar nuestro programa principal o proyecto de consola (Program) nos pararnos en la raiz del proyecto y ejecutamos
```
dotnet run --project src/Program
```
![Use this template](./assets/uses-13.png)


> ⚠ Información
>
>Para realizar este template nos basamos en los comando que se encuentran disponibles en el repositorio de [Comandos](https://github.com/ucudal/PII_Comandos). Las tareas de verificación fueron configuradas utilizando las caracteristicas que [GitHub Action](https://github.com/features/actions) nos ofrece.