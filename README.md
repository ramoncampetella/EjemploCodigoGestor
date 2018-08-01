# Ejemplo codigo gestor

## Motivacion:
La solucion intenta proponer una separacion entre capas dentro de un microservicio, esta desarrollada en .Net Core 2.0

## Diagrama de capas

![Diagrama de capas](https://github.com/ramoncampetella/EjemploCodigoGestor/blob/master/ConceptoCapasMicroServicio/img/Capas%20servicio.JPG)


## Separacion de capas
Las capas son independientes entre si, se comunican por medio de los objetos que son transversales al modelo, estos objetos se dividen en dos tipos:
BizEntities: Son las entidades del dominio del microservicio, estas entidades son internas y no son expuestas.
DTO: Los DTO son objetos de transporte, los mismos carecen de logica, estos son los que se envian y reciben al exterior.

Builders: en la capa REST API tanto cuando se recibe un DTO desde el exterior como cuando se envia uno se transforma la entidad de negocio en DTO, para ello
se utiliza el framework AutoMapper.

## Descripcion de capas
### External consumers
Son los clientes del microservicio, estos concurren al mismo para realizar operaciones utilizando REST. Los mensajes JSON se corresponden a las entidades DTO
utilizados en la capa REST API

### Rest API
Responsabilidad: Exponer los servicios, transformar los DTO en BizEntities.
Es la capa que expone los servicios, los mensajes son los DTO, estos estan en una libreria separada que puede ser utilizada por los clientes.
Esta capa conoce tanto los DTO como los bizentities, ejecuta las llamadas a los managers correspondientes utilizando como mensajes las BizEntities.

