---
title: "Wizard Interface (IDTWizard)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - IDTWizard interface
  - wizards, interface
ms.assetid: 09618d9d-d115-45b6-bccc-de328994b39c
caps.latest.revision: 12
translation.priority.mt: 
  - de-de
  - ja-jp
---
# Wizard Interface (IDTWizard)
The integrated development environment (IDE) uses the <xref:EnvDTE.IDTWizard?qualifyHint=False> interface to communicate with wizards. Wizards must implement this interface in order to be installed in the IDE.  
  
 The <xref:EnvDTE.IDTWizard.Execute?qualifyHint=False> method is the only method associated with the <xref:EnvDTE.IDTWizard?qualifyHint=False> interface. Wizards implement this method and the IDE calls the method on the interface. The following example shows the signature of the method.  
  
```  
/* IDTWizard Method */  
STDMETHOD(Execute)(THIS_  
   /* [in] */ IDispatch *Application,  
   /* [in] */ long hwndOwner,  
   /* [in] */ SAFEARRAY * *ContextParams,  
   /* [in] */ SAFEARRAY * *CustomParams,  
   /* [out] [in] */ wizardResult *RetVal  
   );  
```  
  
 The start mechanism is similar for both the **New Project** and **Add New Item**wizards. To start either, you call the <xref:EnvDTE.IDTWizard?qualifyHint=False> interface defined in Dteinternal.h. The only difference is the set of context and custom parameters that are passed to the interface when the interface is called.  
  
 The following information describes the <xref:EnvDTE.IDTWizard?qualifyHint=False> interface that wizards must implement to work in the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] IDE. The IDE calls the <xref:EnvDTE.IDTWizard.Execute?qualifyHint=False> method on the wizard, passing it the following:  
  
-   The DTE object  
  
     The DTE object is the root of the Automation model.  
  
-   The handle to the window dialog box as shown in the code segment, `hwndOwner ([in] long)`.  
  
     The wizard uses this `hwndOwner` as the parent for the wizard dialog box.  
  
-   Context parameters passed to the interface as variant for SAFEARRAY as shown in the code segment, `[in] SAFEARRAY (VARIANT)* ContextParams`.  
  
     Context parameters contain an array of values that are specific to the kind of wizard being started and the current state of the project. The IDE passes  the context parameters to the wizard. For more information, see [Context Parameters](../vs140/context-parameters.md).  
  
-   Custom parameters passed to the interface as a variant for SAFEARRAY as shown in the code segment, `[in] SAFEARRAY (VARIANT)* CustomParams`.  
  
     Custom parameters contain an array of user-defined parameters. A .vsz file passes custom parameters to the IDE. The values are determined by the `Param=` statements. For more information, see [Custom Parameters](../vs140/custom-parameters.md).  
  
-   Return values for the interface are  
  
    ```  
    wizardResultSuccess = -1,  
    wizardResultFailure = 0  
    wizardResultCancel = 1  
    wizardResultBackout = 2  
    ```  
  
## See Also  
 [Context Parameters](../vs140/context-parameters.md)   
 [Custom Parameters](../vs140/custom-parameters.md)   
 [Wizards](../vs140/wizards.md)   
 [Wizard (.Vsz) File](../vs140/wizard--.vsz--file.md)