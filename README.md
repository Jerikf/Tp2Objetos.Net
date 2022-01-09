# Administración de Pacientes
## Consigna
Nuestro cliente, una clínica privada de la Ciudad Autónoma de Bs As nos ha solicitado
desarrollar un sistema de **Escritorio** que permita llevar adelante el control.
Se deberá poder asignar un paciente y un médico a una consulta. Se deberá poder finalizar
la consulta. No se podrá finalizar la consulta que no se asignó. Si un profesional se
encuentra atendiendo a un paciente se podrá asignar a una lista de espera para ese
profesional.

## Requerimientos
- **Ver la lista de pacientes a la espera de atención ordenados por orden de
llegada.**
    - Se deberá poder visualizar o consultar dni, nombre, apellido, edad del
paciente y obra social (NoTiene, CoberturaBasica, CobreturaCompleta).

- **Ver la lista de médicos disponibles para la atención**
    - Ver la lista de médicos disponibles para la atención
- **Visualizar fácilmente el estado actual del profesional, si está atendiendo o no.**
- **Poder asignar un médico al siguiente paciente en la fila.**
    - No se deben poder asignar a un profesional que se encuentre
atendiendo pacientes
    - No se deben poder asignar a un profesional que se encuentre
atendiendo pacientes
    - Se deberá cambiar el estado de la consulta y al finalizar asignar un resultado
(derivación, indicación de estudios, internacion, cirugia, tratamiento, etc, ser
creativo)
- **Poder indicar la finalización de la consulta.**
    - No se debe poder marcar como finalizada una consulta que no está
activa.
- **Poder visualizar estadísticas históricas:**
    - Lista de profesionales ordenados por cantidad de pacientes atendidos
de forma descendente.
    - El médico que más pacientes atendió.
    - La especialidad con más consultas
    - El médico que menos pacientes atendió.
    
## Condiciones
1. **Los 2 proyectos (Biblioteca de clases y Formularios) deben cumplir las reglas de estilo:**
    - Código correctamente comentado con Summary
    - Nombres de controles con los estilos correspondientes.
    - Los formularios no pueden tener el color por defecto y el nombre debe ser legible al
usuario.
2. **Deben estar presentes las funcionalidades requeridas anteriormente.**
3. **La aplicación debe estar distribuida en secciones de fácil navegación y acceso. Deben**
haber al menos 2 formularios diferentes.
4. **Deben ser utilizados los temas vistos durante la clase. Entre ellos,mismos son:**
    - Herencia
    - Sobrecarga de operadores,constructores y métodos.
    - Sobrecarga de conversores implícitos y explícitos ( al menos uno).
    - Propiedades
    - Colecciones genéricas (al menos 2 colecciones diferentes)
    - Enumerados
    - Formulario.
    - Clases estáticas.
    - Polimorfismo.
5. **No debe generar ningún tipo de error (ni de compilación, ni de ejecución).**
6. **La aplicación deberá tener hardcodeados médicos y pacientes para facilitar la corrección.**
7. **El icono de la aplicación no puede ser el icono por defecto,no puede tener fondo por
defecto.**
8. **Serán valorados a la hora de evaluar la creatividad que se aplique al programa en cuanto
al diseño de la app.**


    


