---
title: "class (C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "class_cpp"
  - "class"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "class types, class statements"
  - "class keyword [C++]"
ms.assetid: dd23c09f-6598-4069-8bff-69c7f2518b9f
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# class (C++)
The `class` keyword declares a class type or defines an object of a class type.  
  
## Syntax  
  
```  
  
      [template-spec]  
       class [ms-decl-spec] [tag [: base-list ]]  
{  
   member-list  
} [declarators];  
[ class ] tag declarators;  
```  
  
#### Parameters  
 `template-spec`  
 Optional template specifications. For more information, refer to [Template Specifications](../Topic/Template%20Specifications.md).  
  
 `class`  
 The `class` keyword.  
  
 `ms-decl-spec`  
 Optional storage-class specification. For more information, refer to the [__declspec](../VS_csharp/__declspec.md) keyword.  
  
 `tag`  
 The type name given to the class. The tag becomes a reserved word within the scope of the class. The tag is optional. If omitted, an anonymous class is defined. For more information, see [Anonymous Class Types](../VS_csharp/anonymous-class-types.md).  
  
 `base-list`  
 Optional list of classes or structures this class will derive its members from. See [Base Classes](../VS_csharp/base-classes.md) for more information. Each base class or structure name can be preceded by an access specifier ([public](../VS_csharp/public--c---.md), [private](../VS_csharp/private--c---.md), [protected](../VS_csharp/protected--c---.md)) and the [virtual](../VS_csharp/virtual--c---.md) keyword. See the member-access table in [Controlling Access to Class Members](../Topic/Controlling%20Access%20to%20Class%20Members.md) for more information.  
  
 `member-list`  
 List of class members. Refer to [Class Members](../VS_csharp/class-member-overview.md) for more information.  
  
 `declarators`  
 Declarator list specifying the names of one or more instances of the class type. Declarators may include initializer lists if all data members of the class are `public`. This is more common in structures, whose data members are `public` by default, than in classes. See [Overview of Declarators](../VS_csharp/overview-of-declarators.md) for more information.  
  
## Remarks  
 For more information on classes in general, refer to one of the following topics:  
  
-   [struct](../VS_csharp/struct--c---.md)  
  
-   [union](../VS_csharp/unions.md)  
  
-   [__multiple_inheritance](../VS_csharp/inheritance-keywords.md)  
  
-   [__single_inheritance](../VS_csharp/inheritance-keywords.md)  
  
-   [__virtual_inheritance](../VS_csharp/inheritance-keywords.md)  
  
 For information on managed classes and structs, see [Classes and Structs](../VS_csharp/classes-and-structs---c---component-extensions-.md)  
  
## Example  
  
```  
// class.cpp  
// compile with: /EHsc  
// Example of the class keyword  
// Exhibits polymorphism/virtual functions.  
  
#include <iostream>  
#include <string>  
#define TRUE = 1  
using namespace std;  
  
class dog  
{  
public:  
   dog()  
   {  
      _legs = 4;  
      _bark = true;  
   }  
  
   void setDogSize(string dogSize)  
   {  
      _dogSize = dogSize;  
   }  
   virtual void setEars(string type)      // virtual function  
   {  
      _earType = type;  
   }  
  
private:  
   string _dogSize, _earType;  
   int _legs;  
   bool _bark;  
  
};  
  
class breed : public dog  
{  
public:  
   breed( string color, string size)  
   {  
      _color = color;  
      setDogSize(size);  
   }  
  
   string getColor()  
   {  
      return _color;  
   }  
  
   // virtual function redefined  
   void setEars(string length, string type)  
   {  
      _earLength = length;  
      _earType = type;  
   }  
  
protected:  
   string _color, _earLength, _earType;  
};  
  
int main()  
{  
   dog mongrel;  
   breed labrador("yellow", "large");  
   mongrel.setEars("pointy");  
   labrador.setEars("long", "floppy");  
   cout << "Cody is a " << labrador.getColor() << " labrador" << endl;  
}  
```  
  
## See Also  
 [Keywords](../VS_csharp/keywords--c---.md)   
 [Classes and Structs](../VS_csharp/classes-and-structs--c---.md)