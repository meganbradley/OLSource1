---
title: "Procedure Overloading (Visual Basic)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - VB
helpviewer_keywords: 
  - signatures
  - Overloads keyword
  - hiding by signature
  - Visual Basic code, procedures
  - procedures, signatures for
  - procedures, overloading
  - procedures, multiple versions
  - parameters, lists
  - signatures, procedure
  - parameter lists
  - Visual Basic code, parameter lists
  - Shadows keyword
  - procedure overloading
  - procedures, parameter lists
ms.assetid: fbc7fb18-e3b2-48b6-b554-64c00ed09d2a
caps.latest.revision: 28
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Procedure Overloading (Visual Basic)
*Overloading* a procedure means defining it in multiple versions, using the same name but different parameter lists. The purpose of overloading is to define several closely related versions of a procedure without having to differentiate them by name. You do this by varying the parameter list.  
  
## Overloading Rules  
 When you overload a procedure, the following rules apply:  
  
-   **Same Name**. Each overloaded version must use the same procedure name.  
  
-   **Different Signature**. Each overloaded version must differ from all other overloaded versions in at least one of the following respects:  
  
    -   Number of parameters  
  
    -   Order of the parameters  
  
    -   Data types of the parameters  
  
    -   Number of type parameters (for a generic procedure)  
  
    -   Return type (only for a conversion operator)  
  
     Together with the procedure name, the preceding items are collectively called the *signature* of the procedure. When you call an overloaded procedure, the compiler uses the signature to check that the call correctly matches the definition.  
  
-   **Items Not Part of Signature**. You cannot overload a procedure without varying the signature. In particular, you cannot overload a procedure by varying only one or more of the following items:  
  
    -   Procedure modifier keywords, such as `Public`, `Shared`, and `Static`  
  
    -   Parameter or type parameter names  
  
    -   Type parameter constraints (for a generic procedure)  
  
    -   Parameter modifier keywords, such as `ByRef` and `Optional`  
  
    -   Whether it returns a value  
  
    -   The data type of the return value (except for a conversion operator)  
  
     The items in the preceding list are not part of the signature. Although you cannot use them to differentiate between overloaded versions, you can vary them among overloaded versions that are properly differentiated by their signatures.  
  
-   **Late-Bound Arguments**. If you intend to pass a late bound object variable to an overloaded version, you must declare the appropriate parameter as <xref:System.Object?qualifyHint=False>.  
  
## Multiple Versions of a Procedure  
 Suppose you are writing a `Sub` procedure to post a transaction against a customer's balance, and you want to be able to refer to the customer either by name or by account number. To accommodate this, you can define two different `Sub` procedures, as in the following example:  
  
 [!code[VbVbcnProcedures#73](../vs140/codesnippet/VisualBasic/procedure-overloading--visual-basic-_1.vb)]
  
  
### Overloaded Versions  
 An alternative is to overload a single procedure name. You can use the [Overloads](../vs140/overloads--visual-basic-.md) keyword to define a version of the procedure for each parameter list, as follows:  
  
 [!code[VbVbcnProcedures#72](../vs140/codesnippet/VisualBasic/procedure-overloading--visual-basic-_2.vb)]
  
  
#### Additional Overloads  
 If you also wanted to accept a transaction amount in either `Decimal` or `Single`, you could further overload `post` to allow for this variation. If you did this to each of the overloads in the preceding example, you would have four `Sub` procedures, all with the same name but with four different signatures.  
  
## Advantages of Overloading  
 The advantage of overloading a procedure is in the flexibility of the call. To use the `post` procedure declared in the preceding example, the calling code can obtain the customer identification as either a `String` or an `Integer`, and then call the same procedure in either case. The following example illustrates this:  
  
 [!code[VbVbcnProcedures#56](../vs140/codesnippet/VisualBasic/procedure-overloading--visual-basic-_3.vb)]
  
  
 [!code[VbVbcnProcedures#57](../vs140/codesnippet/VisualBasic/procedure-overloading--visual-basic-_4.vb)]
  
  
## See Also  
 [Procedures in Visual Basic](../vs140/procedures-in-visual-basic.md)   
 [How to: Define Multiple Versions of a Procedure](../vs140/how-to--define-multiple-versions-of-a-procedure--visual-basic-.md)   
 [How to: Call an Overloaded Procedure](../vs140/how-to--call-an-overloaded-procedure--visual-basic-.md)   
 [How to: Overload a Procedure that Takes Optional Parameters](../vs140/how-to--overload-a-procedure-that-takes-optional-parameters--visual-basic-.md)   
 [How to: Overload a Procedure that Takes an Indefinite Number of Parameters](../vs140/how-to--overload-a-procedure-that-takes-an-indefinite-number-of-parameters--visual-basic-.md)   
 [Considerations in Overloading Procedures](../vs140/considerations-in-overloading-procedures--visual-basic-.md)   
 [Overload Resolution](../vs140/overload-resolution--visual-basic-.md)   
 [Overloads](../vs140/overloads--visual-basic-.md)   
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)