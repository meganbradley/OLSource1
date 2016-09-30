---
title: "AfxOleRegisterControlClass"
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
  - "AfxOleRegisterControlClass"
  - "AFXCTL/AfxOleRegisterControlClass"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AfxOleRegisterControlClass function"
  - "afxRegApartmentThreading function"
  - "afxRegFreeThreading function"
  - "afxRegInsertable function"
  - "apartment model threading"
ms.assetid: 60782b83-e173-499e-a689-1f18f20853b9
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxOleRegisterControlClass
Registers the control class with the Windows registration database.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The instance handle of the module associated with the control class.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The unique class ID of the control.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The unique program ID of the control.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The resource ID of the string that contains a user-readable type name for the control.  
  
 *idBitmap*  
 The resource ID of the bitmap used to represent the OLE control in a toolbar or palette.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Contains one or more of the following flags:  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> Allows the control to appear in the Insert Object dialog box for OLE objects.  
  
-   <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> Sets the threading model in the registry to ThreadingModel=Apartment.  
  
-   <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> Sets the threading model in the registry to ThreadingModel=Free.  
  
     You can combine the two flags <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to set ThreadingModel=Both. See [InprocServer32](http://msdn.microsoft.com/library/windows/desktop/ms682390) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information on threading model registration.  
  
> [!NOTE]
>  In MFC versions before MFC 4.2, the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameter was a **BOOL** parameter, *bInsertable*, that allowed or disallowed the control to be inserted from the Insert Object dialog box.  
  
 *dwMiscStatus*  
 Contains one or more of the following status flags (for a description of the flags, see **OLEMISC** enumeration in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]):  
  
-   OLEMISC_RECOMPOSEONRESIZE  
  
-   OLEMISC_ONLYICONIC  
  
-   OLEMISC_INSERTNOTREPLACE  
  
-   OLEMISC_STATIC  
  
-   OLEMISC_CANTLINKINSIDE  
  
-   OLEMISC_CANLINKBYOLE1  
  
-   OLEMISC_ISLINKOBJECT  
  
-   OLEMISC_INSIDEOUT  
  
-   OLEMISC_ACTIVATEWHENVISIBLE  
  
-   OLEMISC_RENDERINGISDEVICEINDEPENDENT  
  
-   OLEMISC_INVISIBLEATRUNTIME  
  
-   OLEMISC_ALWAYSRUN  
  
-   OLEMISC_ACTSLIKEBUTTON  
  
-   OLEMISC_ACTSLIKELABEL  
  
-   OLEMISC_NOUIACTIVATE  
  
-   OLEMISC_ALIGNABLE  
  
-   OLEMISC_IMEMODE  
  
-   OLEMISC_SIMPLEFRAME  
  
-   OLEMISC_SETCLIENTSITEFIRST  
  
 *tlid*  
 The unique ID of the control class.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The major version number of the control class.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The minor version number of the control class.  
  
## Return Value  
 Nonzero if the control class was registered; otherwise 0.  
  
## Remarks  
 This allows the control to be used by containers that are OLE-control aware. <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> updates the registry with the control's name and location on the system and also sets the threading model that the control supports in the registry. For more information, see [Technical Note 64](../vs140/tn064--apartment-model-threading-in-activex-controls.md), "Apartment-Model Threading in OLE Controls," and [About Processes and Threads](http://msdn.microsoft.com/library/windows/desktop/ms681917) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFCAxCtl#11](../vs140/codesnippet/CPP/afxoleregistercontrolclass_1.cpp)]  
  
 The above example demonstrates how <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is called with the flag for insertable and the flag for apartment model ORed together to create the sixth parameter:  
  
 [!code[NVC_MFCAxCtl#12](../vs140/codesnippet/CPP/afxoleregistercontrolclass_2.cpp)]  
  
 The control will show up in the Insert Object dialog box for enabled containers, and it will be apartment model-aware. Apartment model-aware controls must ensure that static class data is protected by locks, so that while a control in one apartment is accessing the static data, it isn't disabled by the scheduler before it is finished, and another instance of the same class starts using the same static data. Any accesses to the static data will be surrounded by critical section code.  
  
## Requirements  
 **Header:** \<afxctl.h>  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [AfxOleRegisterPropertyPageClass](../vs140/afxoleregisterpropertypageclass.md)   
 [AfxOleRegisterTypeLib](../vs140/afxoleregistertypelib.md)   
 [AfxOleUnregisterClass](../vs140/afxoleunregisterclass.md)   
 [AfxOleUnregisterTypeLib](../vs140/afxoleunregistertypelib.md)