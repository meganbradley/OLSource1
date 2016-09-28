---
title: "Attributes (Visual Basic)2"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "Attributes (Visual Basic)"
dev_langs: 
  - "VB"
ms.assetid: 1449f69b-c063-41de-8d89-f0bbdcf96ac6
caps.latest.revision: 8
author: ""
ms.author: ""
manager: ""
---
# Attributes (Visual Basic)2
Attributes provide a powerful method of associating metadata, or declarative information, with code (assemblies, types, methods, properties, and so forth). After an attribute is associated with a program entity, the attribute can be queried at run time by using a technique called *reflection*. For more information, see [Reflection (Visual Basic)](../vs140/reflection--visual-basic-.md).  
  
 Attributes have the following properties:  
  
-   Attributes add metadata to your program. *Metadata* is information about the types defined in a program. All .NET assemblies contain a specified set of metadata that describes the types and type members defined in the assembly. You can add custom attributes to specify any additional information that is required. For more information, see, [Creating Custom Attributes (Visual Basic)](../vs140/creating-custom-attributes--visual-basic-.md).  
  
-   You can apply one or more attributes to entire assemblies, modules, or smaller program elements such as classes and properties.  
  
-   Attributes can accept arguments in the same way as methods and properties.  
  
-   Your program can examine its own metadata or the metadata in other programs by using reflection. For more information, see [Accessing Attributes by Using Reflection (Visual Basic)](../vs140/accessing-attributes-by-using-reflection--visual-basic-.md).  
  
## Using Attributes  
 Attributes can be placed on most any declaration, though a specific attribute might restrict the types of declarations on which it is valid. In Visual Basic, an attribute is enclosed in angle brackets (< >). It must appear immediately before the element to which it is applied, on the same line.  
  
 In this example, the <xref:System.SerializableAttribute*> attribute is used to apply a specific characteristic to a class:  
  
```vb  
<System.Serializable()> Public Class SampleClass  
    ' Objects of this type can be serialized.  
End Class  
```  
  
 A method with the attribute <xref:System.Runtime.InteropServices.DllImportAttribute*> is declared like this:  
  
```vb  
Imports System.Runtime.InteropServices  
```  
  
```vb  
<System.Runtime.InteropServices.DllImport("user32.dll")>   
Sub SampleMethod()  
End Sub  
```  
  
 More than one attribute can be placed on a declaration:  
  
```vb  
Imports System.Runtime.InteropServices  
```  
  
```vb  
Sub MethodA(<[In](), Out()> ByVal x As Double)  
End Sub  
Sub MethodB(<Out(), [In]()> ByVal x As Double)  
End Sub  
```  
  
 Some attributes can be specified more than once for a given entity. An example of such a multiuse attribute is <xref:System.Diagnostics.ConditionalAttribute*>:  
  
```vb  
<Conditional("DEBUG"), Conditional("TEST1")>   
Sub TraceMethod()  
End Sub  
```  
  
> [!NOTE]
>  By convention, all attribute names end with the word "Attribute" to distinguish them from other items in the .NET Framework. However, you do not need to specify the attribute suffix when using attributes in code. For example, `[DllImport]` is equivalent to `[DllImportAttribute]`, but `DllImportAttribute` is the attribute's actual name in the .NET Framework.  
  
### Attribute Parameters  
 Many attributes have parameters, which can be positional, unnamed, or named. Any positional parameters must be specified in a certain order and cannot be omitted; named parameters are optional and can be specified in any order. Positional parameters are specified first. For example, these three attributes are equivalent:  
  
```vb  
<DllImport("user32.dll")>  
<DllImport("user32.dll", SetLastError:=False, ExactSpelling:=False)>  
<DllImport("user32.dll", ExactSpelling:=False, SetLastError:=False)>  
```  
  
 The first parameter, the DLL name, is positional and always comes first; the others are named. In this case, both named parameters default to false, so they can be omitted. Refer to the individual attribute's documentation for information on default parameter values.  
  
### Attribute Targets  
 The *target* of an attribute is the entity to which the attribute applies. For example, an attribute may apply to a class, a particular method, or an entire assembly. By default, an attribute applies to the element that it precedes. But you can also explicitly identify, for example, whether an attribute is applied to a method, or to its parameter, or to its return value.  
  
 To explicitly identify an attribute target, use the following syntax:  
  
```vb  
<target : attribute-list>  
```  
  
 The list of possible `target` values is shown in the following table.  
  
|Target value|Applies to|  
|------------------|----------------|  
|`assembly`|Entire assembly|  
|`module`|Current assembly module (which is different from a Visual Basic Module)|  
  
 The following example shows how to apply attributes to assemblies and modules. For more information, see [Common Attributes (Visual Basic)](../vs140/common-attributes--visual-basic-.md).  
  
```vb  
Imports System.Reflection  
<Assembly: AssemblyTitleAttribute("Production assembly 4"),   
Module: CLSCompliant(True)>   
```  
  
## Common Uses for Attributes  
 The following list includes a few of the common uses of attributes in code:  
  
-   Marking methods using the `WebMethod` attribute in Web services to indicate that the method should be callable over the SOAP protocol. For more information, see <xref:System.Web.Services.WebMethodAttribute*>.  
  
-   Describing how to marshal method parameters when interoperating with native code. For more information, see <xref:System.Runtime.InteropServices.MarshalAsAttribute*>.  
  
-   Describing the COM properties for classes, methods, and interfaces.  
  
-   Calling unmanaged code using the <xref:System.Runtime.InteropServices.DllImportAttribute*> class.  
  
-   Describing your assembly in terms of title, version, description, or trademark.  
  
-   Describing which members of a class to serialize for persistence.  
  
-   Describing how to map between class members and XML nodes for XML serialization.  
  
-   Describing the security requirements for methods.  
  
-   Specifying characteristics used to enforce security.  
  
-   Controlling optimizations by the just-in-time (JIT) compiler so the code remains easy to debug.  
  
-   Obtaining information about the caller to a method.  
  
## Related Sections  
 For more information, see:  
  
-   [Creating Custom Attributes (Visual Basic)](../vs140/creating-custom-attributes--visual-basic-.md)  
  
-   [Accessing Attributes by Using Reflection (Visual Basic)](../vs140/accessing-attributes-by-using-reflection--visual-basic-.md)  
  
-   [How to: Create a C/C++ Union by Using Attributes (Visual Basic)](../vs140/how-to--create-a-c-c---union-by-using-attributes--visual-basic-.md)  
  
-   [Common Attributes (Visual Basic)](../vs140/common-attributes--visual-basic-.md)  
  
-   [Caller Information (Visual Basic)](../vs140/caller-information--visual-basic-.md)  
  
## See Also  
 [Visual Basic Programming Guide](../vs140/visual-basic-programming-guide.md)   
 [Reflection (Visual Basic)](../vs140/reflection--visual-basic-.md)   
 [Extending Metadata Using Attributes](assetId:///30386922-1e00-4602-9ebf-526b271a8b87)