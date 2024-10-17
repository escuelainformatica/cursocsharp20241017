# cursocsharp20241017

## clase de modelo

### alcance de clase

* una clase internal es una clase que solo funciona dentro del proyecto.
* una clase public, es una clase que puede funcionar dentro y fuera del proyecto.

### alcance de los campos

* Cuando el campo es publico, se puede acceder dentro y fuera de la clase
```csharp
class Ejemplo {
   public string campo;
}	

var ej=new Ejemplo();
ej.campo="hola";
```
Ejemplo de campo es privado
```csharp
class Ejemplo {
   private string campo;
}	

var ej=new Ejemplo();
ej.campo="hola"; // error
```

Hay un concepto que se llama programacion orientada a objeto OOP.

* Los campos de las clases tienen que ser privados.
* En C# si se quiere tener campos publicos, se crean propiedades.

Una clase de modelo normal tiene lo siguiente:
* propiedades
* constructores (opcionales)

## clase de servicio
Las clases de servicio son una coleccion de funciones (o tambien llamado metodos)
Por lo general, las clases de servicios se enfocan en un modelo y en un area (base de datos, validacion, etc.)

* En lo posible, la clase y los metodos se deben generar estaticos, en la medida de lo posible.
* Cuando tengo una clase de servicio estatica, no puede tener campos ni propiedades.
* Una clase de servicio sin campos ni propiedades se llama "Stateless"





