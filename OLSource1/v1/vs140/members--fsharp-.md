---
title: "Members (F#)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-fsharp
ms.tgt_pltfrm: na
ms.topic: reference
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - types [F#], elements of
  - member keyword [F#]
  - members [F#]
ms.assetid: e4d2da65-b822-4605-a6ac-5770c09c75ae
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Members (F#)
This section describes members of F# object types.  
  
## Remarks  
 *Members* are features that are part of a type definition and are declared with the `member` keyword. F# object types such as records, classes, discriminated unions, interfaces, and structures support members. For more information, see [Records (F#)](../vs140/records--fsharp-.md), [Classes (F#)](../vs140/classes--fsharp-.md), [Discriminated Unions](../vs140/discriminated-unions--fsharp-.md), [Interfaces](../vs140/interfaces--fsharp-.md), and [Structures](../vs140/structures--fsharp-.md).  
  
 Members typically make up the public interface for a type, which is why they are public unless otherwise specified. Members can also be declared private or internal. For more information, see [Access Control](../vs140/access-control--fsharp-.md). Signatures for types can also be used to expose or not expose certain members of a type. For more information, see [Signatures (F#)](../vs140/signatures--fsharp-.md).  
  
 Private fields and `do` bindings, which are used only with classes, are not true members, because they are never part of the public interface of a type and are not declared with the `member` keyword, but they are described in this section also.  
  
## Related Topics  
  
|Topic|Description|  
|-----------|-----------------|  
|[Let Bindings in Classes](../vs140/let-bindings-in-classes--fsharp-.md)|Describes the definition of private fields and functions in classes.|  
|[Do Bindings in Classes](../vs140/do-bindings-in-classes--fsharp-.md)|Describes the specification of object initialization code.|  
|[Properties](../vs140/properties--fsharp-.md)|Describes property members in classes and other types.|  
|[Indexed Properties](../vs140/indexed-properties--fsharp-.md)|Describes array-like properties in classes and other types.|  
|[Methods](../vs140/methods--fsharp-.md)|Describes functions that are members of a type.|  
|[Constructors](../vs140/constructors--fsharp-.md)|Describes special functions that initialize objects of a type.|  
|[Operator Overloading](../vs140/operator-overloading--fsharp-.md)|Describes the definition of customized operators for types.|  
|[Events](../vs140/events--fsharp-.md)|Describes the definition of events and event handling support in F#.|  
|[Explicit Fields: the val keyword](../vs140/explicit-fields--the-val-keyword--fsharp-.md)|Describes the definition of uninitialized fields in a type.|