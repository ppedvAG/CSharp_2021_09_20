# CHEATSHEET CSHARP

[classes](#classes) |
[class props](#class-props) |
[constructors](#constructors) |
[class methods](#class-methods)

[variables](#variables)

[conditions](#conditions) | 
[conditionals](#conditionals)

[loops](#loops) | 
[iterators](#iterators)

[instantiation](#instantiation) |
[inheritance](#inheritance) |
[interfaces](#interfaces)

[generic structures](#generic-structures)

[delegates](#delegates) |
[arrow functions](#arrow-functions)

<br><br>

## CLASSES

**SEMANTIC SYNTAX**

Konvention bei Klassennamen - PascalCase<br>
Wenn kein Modifizierer, dann ist es private
Mit Anlegen von Klassen legen wir neue Datentypen an 

```csharp
_modifier_ class _Identifier_
{
    // class members
}
```

**EXAMPLE**

```csharp
public class Person
{
    // class members
}
```

**SNIPPET**

`class` `tab`

**MEMBERS**

Konvention für die Reihenfolge:

```csharp
public class Person
{
    // possibly data types, evtl. Datentypen (enums)
    
    // possibly fields, evtl. Felder

    // possibly properties, evtl. Eigenschaften

    // possibly constructors, evtl. Konstruktoren

    // possibly methods, evtl. Methoden

    // possibly destructor, evtl. Destruktor
}
```

<br><br>

## CLASS PROPS

Konvention - PascalCase

ohne Modifizierer sind get & set public.

**SEMANTIC SYNTAX**

```csharp
public _type_ _Identifier_ { get; set; }
```

**EXAMPLE**

```csharp
public string FirstName { get; set; }
```

**SNIPPET**

 `prop` `tab`

<br><br>

## CONSTRUCTORS

Konstruktoren heißen genauso wie die Klasse selbst! <br>
Konstruktoren haben keinen Rückgabetyp. <br>
Konventionen wie bei anderen Methoden.

**SEMANTIC SYNTAX**

```csharp
public _ClassName_(_type_ _param1_, _type_ _param2_)
{
    _PropName1_ = _param1_;
    _PropName2_ = _param2_;
}
```

**EXAMPLE**

```csharp
public Person(string fn, string ln) 
{
    FirstName = fn;
    LastName = ln;
}
```

**SNIPPET**

`ctor` `tab`

<br><br>

## CLASS METHODS

Konventionen - PascalCase 

Ohne private/public sind die Methoden private

**SEMANTIC SYNTAX**

```csharp
_modifier_ _returntype_ _Identifier_(_parameters_)
{
    // Ausdrücke | Expressions
    // Anweisungen | Statements 
}
```

**EXAMPLE**

```csharp
static void Main(string text)
{
    // Ausdrücke | Expressions
    // Anweisungen | Statements 
}
```

<br><br>

## VARIABLES

Konvention - camelCase.

Beim Deklarieren (ohne Initialisieren) bekommen die Variablen in C# ihre Default-Werte.

**SEMANTIC SYNTAX**

```csharp
// 1. declaring  variables:
_type_ _identifier_;

// 2. writing initial value to declared variables:
_identifier_ = _initialValue_;

// 3. initializing variables (declaring & writing initial value):
_type_ _identifier_ = _initialValue_;

// 4. reading the value from declared/initialized variables:
_SomeMethod_(_identifier_);
_identifierOfAnotherVariable_ = _identifier_;

// 5. writing a new value is the same as 2. writing initial value:
_identifier_ = _newValue_;
```

**EXAMPLE**

```csharp
// 1. declaring  variables:
int geburtsjahr;

// 2. writing initial value to declared variables:
geburtsjahr = 1970;

// 3. initializing variables (declaring & writing initial value):
string wohnort = "Leipzig";

// 4. reading the value from declared/initialized variables:
Console.Write("Ich wohne in " + wohnort + ".");
int alter = 2020 - geburtsjahr;

// 5. writing a new value is the same as 2. writing initial value:
wohnort = "Berlin";
```

<br><br>

## CONDITIONS

#### SINGLE CONDITION

**SEMANTIC SYNTAX**

```csharp
_value1_ == / != / > / >= / < / <= _value2_
```

**EXAMPLE**

```csharp
Person.Firstname == "Max"
```

<br>

#### MANY CONDITIONS

**SEMANTIC SYNTAX**

```csharp
_condition1_ && / || / ^ _condition2_
```

**EXAMPLE**

```csharp
myPerson.Firstname == "Max" && myPerson.Age < 30
```

<br><br>

## CONDITIONALS

### IF

**SEMANTIC SYNTAX**

```csharp
if (_condition_)
{
    // true-Block
}
else
{
    // false-Block
}
```

**EXAMPLE**

```csharp
if (DateTime.Now == "22.04.2020")
{
    Console.WriteLine("Tag für Sport");
}
```

<br>

### IF-EXPRESSION

```csharp
true ? "true" : "false";
```

<br><br>

## LOOPS

### FOR-LOOP

**SEMANTIC SYNTAX**

```csharp
for (_iteratorVariable_; _conditionWithIteratorVariable_; _iteratorVariableChanges_)
{
    // do smth, using the iteratorVariable
}
```

**EXAMPLE**

```csharp
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
```

**SNIPPET**

`for` `tab`

<br>

### WHILE-LOOP

**SEMANTIC SYNTAX**

```csharp
while (_condition_)
{
    // do smth, using things, mentioned in condition
}
```

**EXAMPLE**

```csharp
int i = 0;
while (i < 10)
{
    Console.WriteLine(i);
    i++;
}
```

**SNIPPET**

`while` `tab`

<br>

### DO-WHILE-LOOP

**SEMANTIC SYNTAX**

```csharp
do 
{
    // do smth, using things, mentioned in condition
} 
while (_condition_)
```

**EXAMPLE**

```csharp
int i = 0;
do
{
    Console.WriteLine(i);
    i++;
}
while (i < 10)
```

**SNIPPET**

`do` `tab`

<br><br>

## ITERATORS

**SEMANTIC SYNTAX**

```csharp
foreach (_type_ _variable_ in _collection_)
{
    // read value of variable
}

```

**EXAMPLE**

```csharp
foreach (string city in cities)
{
    Console.WriteLine($"Stadt: {city}");
}
```

**SNIPPET**

`foreach` `tab`

<br><br>

## INSTANTIATION

Instanz / Objekt / Variable von einer Klasse erstellen

**SEMANTIC SYNTAX**

```csharp
_VariableType_ _variable_ = new _ConstructorOfRuntimeType_();
```

**EXAMPLE**

```csharp
MyClass myClass = new MyClass();
```

<br><br>

## INHERITANCE

**SEMANTIC SYNTAX**

```csharp
```

**EXAMPLE**

```csharp
// Superklasse / Baseklasse / Vaterklasse:
public class Transportmittel
{
    // props:
    public string Name { get; set; }
    public double Preis { get; set; }
    // ctor:
    public Transport(string name, double preis)
    {
        Name = name;
        Preis = preis;
    }
}
// Subklasse / Kindklasse:
class Flugzeug : Transportmittel
{   
    // props:
    public int MaxFlugHoehe { get; set; }
    // ctor:
    public Flugzeug(string name, int preis, int maxFHoehe) : base(name, preis)
    {
        MaxFlugHoehe = maxFHoehe;            
    }
}
```

<br><br>

## INTERFACES

Konvention bei Schnittstellen - IPascalCase

**SEMANTIC SYNTAX**

```csharp
```

**EXAMPLE**

```csharp
// interface deklarieren:
public interface IKannRollen
{
    int AnzahlRaeder { get; set; }
    int Luftdruck { get; set; }
    int NachpumpenLuftDruck(int luft);
}

// interface benutzen:
class Flugzeug : IKannRollen
{       
    // ... props speziell von Flugzeug
    public int AnzahlRaeder { get; set; }
    public int Luftdruck { get; set; }
    // ... ctor weggelassen
    public int NachpumpenLuftDruck(int luft)
    {            
        Luftdruck += luft;
        return 4;
    }
}
```



<br><br>

## GENERIC STRUCTURES

**SEMANTIC SYNTAX**

```csharp
```

**EXAMPLE**

```csharp
List<DateTime> dateTimes = new List<DateTime>();
dateTimes.Add(DateTime.Now);
```

<br><br>

## DELEGATES

**SEMANTIC SYNTAX**

```csharp
```

**EXAMPLE**

```csharp
int Addiere(int a, int b)
   {
       MessageBox.Show($"Addiere: {a + b}");
       return a + b;
   }
Func<int, int, int> myFuncDelegate = Addiere;
myFuncDelegate(3, 4);
```

<br><br>

## ARROW FUNCTIONS

**SEMANTIC SYNTAX**

```csharp
```

**EXAMPLE**

```csharp
gefundeneStadt = staedte.Find(s => s.StartsWith("P"));
```