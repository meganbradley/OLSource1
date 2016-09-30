---
title: "CMFCLinkCtrl Class"
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
  - "CMFCLinkCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCLinkCtrl class"
ms.assetid: 80f3874d-7cc8-410e-9ff1-62a225f5034b
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCLinkCtrl Class
The `CMFCLinkCtrl` class displays a button as a hyperlink and invokes the link's target when the button is clicked.  
  
## Syntax  
  
```  
class CMFCLinkCtrl : public CMFCButton  
```  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCLinkCtrl::SetURL](#cmfclinkctrl__seturl)|Displays a specified URL as the button text.|  
|[CMFCLinkCtrl::SetURLPrefix](#cmfclinkctrl__seturlprefix)|Sets the implicit protocol (for example, "http:") of the URL.|  
|[CMFCLinkCtrl::SizeToContent](#cmfclinkctrl__sizetocontent)|Resizes the button to contain the button text or bitmap.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCLinkCtrl::OnDrawFocusRect](#cmfclinkctrl__ondrawfocusrect)|Called by the framework before the focus rectangle of the button is drawn.|  
  
## Remarks  
 When you click a button that is derived from the `CMFCLinkCtrl` class, the framework passes the URL of the button as a parameter to the `ShellExecute` method. Then the `ShellExecute` method opens the target of the URL.  
  
## Example  
 The following example demonstrates how to set the size of a `CMFCLinkCtrl` object, and how to set a url and a tooltip in a `CMFCLinkCtrl` object. This example is part of the [New Controls sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_NewControls#9](../vs140/codesnippet/CPP/cmfclinkctrl-class_1.h)]  
[!code[NVC_MFC_NewControls#10](../vs140/codesnippet/CPP/cmfclinkctrl-class_2.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CButton](../vs140/cbutton-class.md)  
  
 [CMFCButton](../vs140/cmfcbutton-class.md)  
  
 [CMFCLinkCtrl](../vs140/cmfclinkctrl-class.md)  
  
## Requirements  
 **Header:** afxlinkctrl.h  
  
##  <a name="cmfclinkctrl__ondrawfocusrect"></a>  CMFCLinkCtrl::OnDrawFocusRect  
 Called by the framework before the focus rectangle of the button is drawn.  
  
```  
virtual void OnDrawFocusRect(  
   CDC* pDC,  
   const CRect& rectClient   
);  
```  
  
### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `rectClient`  
 A rectangle that bounds the link control.  
  
### Remarks  
 Override this method when you want to use your own code to draw the button's focus rectangle.  
  
##  <a name="cmfclinkctrl__seturl"></a>  CMFCLinkCtrl::SetURL  
 Displays a specified URL as the button text.  
  
```  
void SetURL(  
   LPCTSTR lpszURL   
);  
```  
  
### Parameters  
 [in] `lpszURL`  
 The button text to display.  
  
### Remarks  
  
##  <a name="cmfclinkctrl__seturlprefix"></a>  CMFCLinkCtrl::SetURLPrefix  
 Sets the implicit protocol (for example, "http:") of the URL.  
  
```  
void SetURLPrefix(  
   LPCTSTR lpszPrefix   
);  
```  
  
### Parameters  
 [in] `lpszPrefix`  
 The prefix of the URL protocol.  
  
### Remarks  
 Use this method to set the URL prefix. The prefix is not displayed on the button's face, but you can use it to help browse to the URL's target.  
  
##  <a name="cmfclinkctrl__sizetocontent"></a>  CMFCLinkCtrl::SizeToContent  
 Resizes the button to contain the button text or bitmap.  
  
```  
virtual CSize SizeToContent(  
   BOOL bVCenter=FALSE,  
   BOOL bHCenter=FALSE   
);  
```  
  
### Parameters  
 [in] `bVCenter`  
 `TRUE` to center the button text and bitmap vertically between the top and bottom of the link control; otherwise, `FALSE`. The default value is `FALSE`.  
  
 [in] `bHCenter`  
 `TRUE` to center the button text and bitmap horizontally between the left and right sides of the link control; otherwise, `FALSE`. The default value is `FALSE`.  
  
### Return Value  
 A [CSize](../vs140/csize-class.md) object that contains the new size of the link control.  
  
### Remarks  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CLinkCtrl Class](../vs140/clinkctrl-class.md)   
 [CMFCButton](../vs140/cmfcbutton-class.md)