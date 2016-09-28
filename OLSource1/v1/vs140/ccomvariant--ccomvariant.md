---
title: "CComVariant::CComVariant"
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
  - "ATL.CComVariant.CComVariant"
  - "CComVariant::CComVariant"
  - "ATL::CComVariant::CComVariant"
  - "CComVariant.CComVariant"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComVariant class, constructor"
  - "CComVariant constructor"
ms.assetid: 273b3b8f-f9f4-4d15-8d95-002df57e3b62
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComVariant::CComVariant
Each constructor handles the safe initialization of the `CComVariant` object by calling the `VariantInit` Win32 function or by setting the object's value and type according to the parameters passed.  
  
## Syntax  
  
```  
  
      CComVariant( ) throw();   
CComVariant(  
   const CComVariant& varSrc   
);  
CComVariant(  
   const VARIANT& varSrc   
);  
CComVariant(  
   LPCOLESTR lpszSrc   
);  
CComVariant(  
   LPCSTR lpszSrc   
);  
CComVariant(  
   bool bSrc   
);  
CComVariant(  
   BYTE nSrc   
) throw();  
CComVariant(  
   int nSrc,  
   VARTYPE vtSrc = VT_I4  
) throw();  
CComVariant(  
   unsigned int nSrc,  
   VARTYPE vtSrc = VT_UI4  
) throw();  
CComVariant(  
   short nSrc   
) throw();  
CComVariant(  
   unsigned short nSrc   
) throw();  
CComVariant(  
   long nSrc,  
   VARTYPE vtSrc = VT_I4   
) throw();  
CComVariant(  
   unsigned long nSrc   
) throw();  
CComVariant(  
   LONGLONG nSrc  
) throw();  
CComVariant(  
   ULONGLONG nSrc  
) throw();  
CComVariant(  
   float fltSrc   
) throw();  
CComVariant(  
   double dblSrc,  
   VARTYPE vtSrc = VT_R8   
) throw();  
CComVariant(  
   CY cySrc   
) throw();  
CComVariant(  
   IDispatch* pSrc   
) throw();  
CComVariant(  
   IUnknown* pSrc   
) throw();  
CComVariant(  
   const SAFEARRAY *pSrc   
);  
CComVariant(  
   char cSrc   
) throw();  
CComVariant(  
   const CComBSTR& bstrSrc   
);  
```  
  
#### Parameters  
 *varSrc*  
 [in] The `CComVariant` or `VARIANT` used to initialize the `CComVariant` object. The contents of the source variant are copied to the destination without conversion.  
  
 `lpszSrc`  
 [in] The character string used to initialize the `CComVariant` object. You can pass a zero-terminated wide (Unicode) character string to the **LPCOLESTR** version of the constructor or an ANSI string to the `LPCSTR` version. In either case the string is converted to a Unicode `BSTR` allocated using **SysAllocString**. The type of the `CComVariant` object will be `VT_BSTR`.  
  
 `bSrc`  
 [in] The `bool` used to initialize the `CComVariant` object. The `bool` argument is converted to a **VARIANT_BOOL** before being stored. The type of the `CComVariant` object will be `VT_BOOL`.  
  
 `nSrc`  
 [in] The `int`, **BYTE**, **short**, **long**, **LONGLONG**, **ULONGLONG**, **unsigned short**, `unsigned long`, or `unsigned int` used to initialize the `CComVariant` object. The type of the `CComVariant` object will be `VT_I4`, `VT_UI1`, `VT_I2`, `VT_I4`, **VT_I8**, **VT_UI8**, **VT_UI2**, **VT_UI4**, or **VT_UI4**, respectively.  
  
 `vtSrc`  
 [in] The type of the variant. When the first parameter is `int`, valid types are `VT_I4` and **VT_INT**. When the first parameter is **long**, valid types are `VT_I4` and `VT_ERROR`. When the first parameter is **double**, valid types are `VT_R8` and `VT_DATE`. When the first parameter is `unsigned int`, valid types are **VT_UI4** and **VT_UINT**.  
  
 `fltSrc`  
 [in] The **float** used to initialize the `CComVariant` object. The type of the `CComVariant` object will be `VT_R4`.  
  
 `dblSrc`  
 [in] The **double** used to initialize the `CComVariant` object. The type of the `CComVariant` object will be `VT_R8`.  
  
 `cySrc`  
 [in] The **CY** used to initialize the `CComVariant` object. The type of the `CComVariant` object will be `VT_CY`.  
  
 `pSrc`  
 [in] The `IDispatch` or **IUnknown** pointer used to initialize the `CComVariant` object. `AddRef` will be called on the interface pointer. The type of the `CComVariant` object will be **VT_DISPATCH** or **VT_UNKNOWN**, respectively.  
  
 Or, the **SAFERRAY** pointer used to initialize the `CComVariant` object. A copy of the **SAFEARRAY** is stored in the `CComVariant` object. The type of the `CComVariant` object will be a combination of the original type of the **SAFEARRAY** and **VT_ARRAY**.  
  
 `cSrc`  
 [in] The `char` used to initialize the `CComVariant` object. The type of the `CComVariant` object will be **VT_I1**.  
  
 `bstrSrc`  
 [in] The BSTR used to initialize the `CComVariant` object. The type of the `CComVariant` object will be `VT_BSTR`.  
  
## Remarks  
 The destructor manages cleanup by calling [CComVariant::Clear](../vs140/ccomvariant--clear.md).  
  
## Requirements  
 **Header:** atlcomcli.h  
  
## See Also  
 [CComVariant Class](../vs140/ccomvariant-class.md)