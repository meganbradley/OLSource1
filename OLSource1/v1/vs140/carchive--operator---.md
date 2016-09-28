---
title: "CArchive::operator &gt;&gt;"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CArchive.operator>>"
  - "CArchive::operator>>"
  - "operator>>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - ">> operator, archived data"
  - "64-bit integers [C++]"
  - "operator>>"
  - "CArchive class, basic input/output"
  - "operator >>, loading archived data"
  - "I/O [C++], CArchive class"
  - "64-bit integers [C++], loading"
  - "operator>>, loading archived data"
ms.assetid: 0c74e8fa-bfdd-4f06-93a7-f615d39b224e
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CArchive::operator &gt;&gt;
Loads the indicated object or primitive type from the archive.  
  
## Syntax  
  
```  
  
      friend CArchive& operator >>(  
   CArchive& ar,  
   CObject *& pOb   
);  
throw(  
   CArchiveException*,  
   CFileException*,  
   CMemoryException*   
);  
friend CArchive& operator >>(  
   CArchive& ar,  
   const CObject *& pOb   
);  
throw(  
   CArchiveException*,  
   CFileException*,  
   CMemoryException*   
);  
CArchive& AFXAPI operator >>(   
   CArchive& ar,  
   const RECT& rect  
);  
CArchive& AFXAPI operator >>(   
   CArchive& ar,   
   POINT point   
);  
CArchive& AFXAPI operator >>(   
  CArchive& ar,   
   SIZE size   
);  
template<    
   typename BaseType,    
   class StringTraits    
>   
CArchive& operator>>(   
   ATL::CStringT<   
      BaseType,    
      StringTraits   
   >& str   
);  
CArchive& operator >>(  
   BYTE& by   
);  
CArchive& operator >>(  
   WORD& w   
);  
CArchive& operator >>(  
   int& i   
);  
CArchive& operator >>(  
   LONG& l   
);  
CArchive& operator >>(  
   DWORD& dw   
);  
CArchive& operator >>(  
   float& f   
);  
CArchive& operator >>(  
   double& d   
);  
CArchive& operator >>(  
   short& w   
);  
CArchive& operator >>(  
   char& ch   
);  
CArchive& operator>>(   
   wchar_t& ch);  
CArchive& operator >>(  
   unsigned& u   
);  
CArchive& operator >>(  
   bool& b   
);  
CArchive& operator >>(   
   ULONGLONG& dwdw    
);  
CArchive& operator >>(   
   LONGLONG& dwdw    
);  
```  
  
## Return Value  
 A `CArchive` reference that enables multiple extraction operators on a single line.  
  
## Remarks  
 The last two versions above are specifically for loading 64-bit integers.  
  
 If you used the `IMPLEMENT_SERIAL` macro in your class implementation, then the extraction operators overloaded for `CObject` call the protected **ReadObject** function (with a nonzero run-time class pointer). This function, in turn, calls the `Serialize` function of the class.  
  
 The [CStringT](../vs140/cstringt-class.md) extraction operator (>>) supports loading from an archive.  
  
## Example  
 This example demonstrates the use of the `CArchive` extraction operator >> with the `int` type.  
  
 [!code[NVC_MFCSerialization#33](../vs140/codesnippet/CPP/carchive--operator---_1.cpp)]  
  
## Example  
 This example demonstrates the use of the `CArchive` insertion and extraction operators << and >> with the `CStringT` type.  
  
 [!code[NVC_MFCSerialization#34](../vs140/codesnippet/CPP/carchive--operator---_2.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CArchive Class](../vs140/carchive-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CArchive::ReadObject](../vs140/carchive--readobject.md)   
 [CObject::Serialize](../vs140/cobject--serialize.md)