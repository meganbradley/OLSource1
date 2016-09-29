---
title: "Changing View Settings by Using the Legacy API"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "editors [Visual Studio SDK], legacy - changing view settings"
ms.assetid: 12c9b300-0894-4124-96a1-764326176d77
caps.latest.revision: 22
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Changing View Settings by Using the Legacy API
Settings for core editor features, such as word wrap, selection margin, and virtual space, can be changed by the user by means of the **Options** dialog box. However, it is also possible to change these settings programmatically.  
  
## Changing Settings by Using the Legacy API  
 The <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextEditorPropertyCategoryContainer*> interface exposes a set of text editor properties. The text view contains a category of properties (GUID_EditPropCategory_View_MasterSettings) that represents the group of programmatically changed settings for the text view. Once view settings have been changed in this way, they cannot be changed in the **Options** dialog box until they are reset.  
  
 Following is the typical process for changing view settings for an instance of the core editor.  
  
1.  Call `QueryInterface` on the (<xref:Microsoft.VisualStudio.TextManager.Interop.VsTextView*>) for the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextEditorPropertyCategoryContainer*> interface.  
  
2.  Call the [GetPropertyCategory](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextEditorPropertyCategoryContainer.GetPropertyCategory(System.Guid@,Microsoft.VisualStudio.TextManager.Interop.IVsTextEditorPropertyContainer@)?qualifyHint=False&autoUpgrade=True) method, specifying a value of GUID_EditPropCategory_View_MasterSettings for the `rguidCategory` parameter.  
  
     Doing this returns a pointer to the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextEditorPropertyCategoryContainer*> interface, which contains the set of forced properties for the view. Any settings in this group are permanently forced. If a setting is not in this group, then it will follow the options specified in the **Options** dialog box or the user's commands.  
  
3.  Call the [SetProperty](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextEditorPropertyContainer.SetProperty(Microsoft.VisualStudio.TextManager.Interop.VSEDITPROPID,System.Object)?qualifyHint=False&autoUpgrade=True) method, specifying the appropriate settings value in the `idprop` parameter.  
  
     For example, to force word wrap, call assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextEditorPropertyContainer.SetProperty(Microsoft.VisualStudio.TextManager.Interop.VSEDITPROPID,System.Object)?qualifyHint=False&autoUpgrade=True and specify a value of VSEDITPROPID_ViewLangOpt_WordWrap, `vt` for the `idprop` parameter. In this call, `vt` is a VARIANT of type VT_BOOL and `vt.boolVal` is VARIANT_TRUE.  
  
## Resetting Changed View Settings  
 To reset any changed view setting for an instance of the core editor, call the [RemoveProperty](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextEditorPropertyContainer.RemoveProperty(Microsoft.VisualStudio.TextManager.Interop.VSEDITPROPID)?qualifyHint=False&autoUpgrade=True) method and specify the appropriate setting value in the `idprop` parameter.  
  
 For example, to allow word wrap to float freely, you would remove it from the property category by calling assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextEditorPropertyContainer.RemoveProperty(Microsoft.VisualStudio.TextManager.Interop.VSEDITPROPID)?qualifyHint=False&autoUpgrade=True and specifying a value of VSEDITPROPID_ViewLangOpt_WordWrap for the `idprop` parameter.  
  
 To remove all changed settings for the core editor at once, specify a value of VSEDITPROPID_ViewComposite_AllCodeWindowDefaults, vt for the `idprop` parameter. In this call, vt is a VARIANT of type VT_BOOL and vt.boolVal is VARIANT_TRUE.  
  
## See Also  
 [Core Editor Overview](../vs140/inside-the-core-editor.md)   
 [Accessing theText View by Using the Legacy API](../vs140/accessing-thetext-view-by-using-the-legacy-api.md)   
 [Options Dialog Box (Visual Studio)](../vs140/options-dialog-box--visual-studio-.md)