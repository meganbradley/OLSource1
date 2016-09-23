---
title: "How to: Enumerate Data Types in Assemblies using Reflection (C++-CLI)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
H1: How to: Enumerate Data Types in Assemblies using Reflection (C++/CLI)
dev_langs: 
  - C++
helpviewer_keywords: 
  - assemblies [C++], enumerating data types in
  - public types [C++]
  - reflection [C++], external assemblies
  - assemblies [C++]
  - data types [C++], enumerating
  - public members [C++]
ms.assetid: c3578e6d-bb99-4599-80e1-ab795305f878
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Enumerate Data Types in Assemblies using Reflection (C++-CLI)
The following code demonstrates the enumeration of public types and members using <xref:System.Reflection?qualifyHint=False>.  
  
 Given the name of an assembly, either in the local directory or in the GAC, the code below attempts to open the assembly and retrieve descriptions. If successful, each type is displayed with its public members.  
  
 Note that <xref:System.Reflection.Assembly.Load?qualifyHint=True> requires that no file extension is used. Therefore, using "mscorlib.dll" as a command-line argument will fail, while using just "mscorlib" will result the display of the .NET Framework types. If no assembly name is provided, the code will detect and report the types within the current assembly (the EXE resulting from this code).  
  
## Example  
  
```  
// self_reflection.cpp  
// compile with: /clr  
using namespace System;  
using namespace System::Reflection;  
using namespace System::Collections;  
  
public ref class ExampleType {  
public:  
   ExampleType() {}  
   void Func() {}  
};  
  
int main() {  
   String^ delimStr = " ";  
   array<Char>^ delimiter = delimStr->ToCharArray( );  
   array<String^>^ args = Environment::CommandLine->Split( delimiter );  
  
// replace "self_reflection.exe" with an assembly from either the local  
// directory or the GAC  
   Assembly^ a = Assembly::LoadFrom("self_reflection.exe");  
   Console::WriteLine(a);  
  
   int count = 0;  
   array<Type^>^ types = a->GetTypes();  
   IEnumerator^ typeIter = types->GetEnumerator();  
  
   while ( typeIter->MoveNext() ) {  
      Type^ t = dynamic_cast<Type^>(typeIter->Current);  
      Console::WriteLine("   {0}", t->ToString());  
  
      array<MemberInfo^>^ members = t->GetMembers();  
      IEnumerator^ memberIter = members->GetEnumerator();  
      while ( memberIter->MoveNext() ) {  
         MemberInfo^ mi = dynamic_cast<MemberInfo^>(memberIter->Current);  
         Console::Write("      {0}", mi->ToString( ) );  
         if (mi->MemberType == MemberTypes::Constructor)  
            Console::Write("   (constructor)");  
  
         Console::WriteLine();  
      }  
      count++;  
   }  
   Console::WriteLine("{0} types found", count);  
}  
```  
  
## See Also  
 [Reflection in C++](../vs140/reflection--c---cli-.md)