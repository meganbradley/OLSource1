---
title: "CComVariant::operator ="
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
  - "CComVariant.operator="
  - "ATL.CComVariant.operator="
  - "CComVariant::operator="
  - "ATL::CComVariant::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "= operator, with specific ATL objects"
  - "operator=, variant"
  - "operator =, variant"
ms.assetid: c0ae51a7-5e2a-48f2-bdd7-20e94f5bc31d
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComVariant::operator =
Assigns a value and corresponding type to the `CComVariant` object.  
  
## Syntax  
  
```  
  
      CComVariant& operator =(  
   const CComVariant& varSrc   
);  
CComVariant& operator =(  
   const VARIANT& varSrc   
);  
CComVariant& operator =(  
   const CComBSTR& bstrSrc  
);  
CComVariant& operator =(  
   LPCOLESTR lpszSrc   
);  
CComVariant& operator =(  
   LPCSTR lpszSrc   
);  
CComVariant& operator =(  
   bool bSrc   
);  
CComVariant& operator =(  
   BYTE nSrc   
) throw();  
CComVariant& operator =(  
   int nSrc   
) throw();  
CComVariant& operator =(  
   unsigned int nSrc   
) throw();  
CComVariant& operator =(  
   short nSrc   
) throw();  
CComVariant& operator =(  
   unsigned short nSrc   
) throw();  
CComVariant& operator =(  
   long nSrc   
) throw();  
CComVariant& operator =(  
   unsigned long nSrc   
) throw();  
CComVariant& operator =(  
   LONGLONG nSrc   
) throw();  
CComVariant& operator =(  
   ULONGLONG nSrc   
) throw();  
CComVariant& operator =(  
   float fltSrc   
) throw();  
CComVariant& operator =(  
   double dblSrc   
) throw();  
CComVariant& operator =(  
   CY cySrc   
) throw();  
CComVariant& operator =(  
   IDispatch* pSrc   
) throw();  
CComVariant& operator =(  
   IUnknown* pSrc   
) throw();  
CComVariant& operator =(  
   const SAFEARRAY *pSrc   
);  
CComVariant& operator =(  
   char cSrc   
) throw();  
```  
  
#### Parameters  
 *varSrc*  
 [in] The `CComVariant` or [VARIANT](assetId:///e305240e-9e11-4006-98cc-26f4932d2118) to be assigned to the `CComVariant` object. The contents of the source variant are copied to the destination without conversion.  
  
 `bstrSrc`  
 [in] The BSTR to be assigned to the `CComVariant` object. The type of the `CComVariant` object will be `VT_BSTR`.  
  
 `lpszSrc`  
 [in] The character string to be assigned to the `CComVariant` object. You can pass a zero-terminated wide (Unicode) character string to the **LPCOLESTR** version of the operator or an ANSI string to the `LPCSTR` version. In either case, the string is converted to a Unicode `BSTR` allocated using **SysAllocString**. The type of the `CComVariant` object will be `VT_BSTR`.  
  
 `bSrc`  
 [in] The `bool` to be assigned to the `CComVariant` object. The `bool` argument is converted to a **VARIANT_BOOL** before being stored. The type of the `CComVariant` object will be `VT_BOOL`.  
  
 `nSrc`  
 [in] The `int`, **BYTE**, **short**, **long**, **LONGLONG**, **ULONGLONG**, **unsigned short**, `unsigned long`, or `unsigned int` to be assigned to the `CComVariant` object. The type of the `CComVariant` object will be `VT_I4`, `VT_UI1`, `VT_I2`, `VT_I4`, **VT_I8**, **VT_UI8**, **VT_UI2**, **VT_UI4**, or **VT_UI4**, respectively.  
  
 `fltSrc`  
 [in] The **float** to be assigned to the `CComVariant` object. The type of the `CComVariant` object will be `VT_R4`.  
  
 `dblSrc`  
 [in] The **double** to be assigned to the `CComVariant` object. The type of the `CComVariant` object will be `VT_R8`.  
  
 `cySrc`  
 [in] The **CY** to be assigned to the `CComVariant` object. The type of the `CComVariant` object will be `VT_CY`.  
  
 `pSrc`  
 [in] The `IDispatch` or **IUnknown** pointer to be assigned to the `CComVariant` object. `AddRef` will be called on the interface pointer. The type of the `CComVariant` object will be **VT_DISPATCH** or **VT_UNKNOWN**, respectively.  
  
 Or, a **SAFEARRAY** pointer to be assigned to the `CComVariant` object. A copy of the **SAFEARRAY** is stored in the `CComVariant` object. The type of the `CComVariant` object will be a combination of the original type of the **SAFEARRAY** and **VT_ARRAY**.  
  
 `cSrc`  
 [in] The char to be assigned to the `CComVariant` object. The type of the `CComVariant` object will be **VT_I1**.  
  
## Requirements  
 **Header:** atlcomcli.h  
  
## See Also  
 [CComVariant Class](../vs140/ccomvariant-class.md)   
 [CComVariant::Copy](../vs140/ccomvariant--copy.md)   
 [VARIANT](assetId:///e305240e-9e11-4006-98cc-26f4932d2118)