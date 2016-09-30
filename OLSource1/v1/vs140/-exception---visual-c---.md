---
title: "&lt;exception&gt; (Visual C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "exception"
  - "<exception>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "<exception> C++ XML tag"
  - "exception C++ XML tag"
ms.assetid: 24451e79-9b89-4b77-98fb-702c6516b818
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;exception&gt; (Visual C++)
The \<exception> tag lets you specify which exceptions can be thrown. This tag is applied to a method definition.  
  
## Syntax  
  
```  
<exception cref="member">description</exception>  
```  
  
#### Parameters  
 `member`  
 A reference to an exception that is available from the current compilation environment. Using name lookup rules, the compiler checks that the given exception exists, and translates `member` to the canonical element name in the output XML.  The compiler issues a warning if it does not find `member`.  
  
 Enclose the name in single or double quotation marks.  
  
 For information on how to create a cref reference to a generic type, see [\<see> (C++)](../vs140/-see---visual-c---.md).  
  
 `description`  
 A description.  
  
## Remarks  
 Compile with [/doc](../vs140/-doc--process-documentation-comments---c-c---.md) to process documentation comments to a file.  
  
 The Visual C++ compiler will attempt to resolve cref references in one pass through the documentation comments.  Therefore, if using the C++ lookup rules, a symbol is not found by the compiler the reference will be marked as unresolved. See [\<seealso> (C++)](../vs140/-seealso---visual-c---.md) for more information.  
  
## Example  
  
```  
// xml_exception_tag.cpp  
// compile with: /clr /doc /LD  
// post-build command: xdcmake xml_exception_tag.dll  
using namespace System;  
  
/// Text for class EClass.  
public ref class EClass : public Exception {  
   // class definition ...  
};  
  
/// <exception cref="System.Exception">Thrown when... .</exception>  
public ref class TestClass {  
   void Test() {  
      try {  
      }  
      catch(EClass^) {  
      }  
   }  
};  
```  
  
## See Also  
 [XML Documentation](../vs140/xml-documentation--visual-c---.md)