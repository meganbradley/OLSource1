---
title: "Walkthrough: Encrypting and Decrypting Strings in Visual Basic"
ms.custom: na
ms.date: 09/21/2016
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
  - encryption, strings
  - strings [Visual Basic], encrypting
  - decryption, strings
  - strings [Visual Basic], decrypting
ms.assetid: 1f51e40a-2f88-43e2-a83e-28a0b5c0d6fd
caps.latest.revision: 22
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Walkthrough: Encrypting and Decrypting Strings in Visual Basic
This walkthrough shows you how to use the <xref:System.Security.Cryptography.DESCryptoServiceProvider?qualifyHint=False> class to encrypt and decrypt strings using the cryptographic service provider (CSP) version of the Triple Data Encryption Standard (<xref:System.Security.Cryptography.TripleDES?qualifyHint=False>) algorithm. The first step is to create a simple wrapper class that encapsulates the 3DES algorithm and stores the encrypted data as a base-64 encoded string. Then, that wrapper is used to securely store private user data in a publicly accessible text file.  
  
 You can use encryption to protect user secrets (for example, passwords) and to make credentials unreadable by unauthorized users. This can protect an authorized user's identity from being stolen, which protects the user's assets and provides non-repudiation. Encryption can also protect a user's data from being accessed by unauthorized users.  
  
 For more information, see [Cryptography Overview](assetId:///f96284bc-7b73-44b5-ac59-fac613ad09f8).  
  
> [!IMPORTANT]
>  The Rijndael (now referred to as Advanced Encryption Standard [AES]) and Triple Data Encryption Standard (3DES) algorithms provide greater security than DES because they are more computationally intensive. For more information, see <xref:System.Security.Cryptography.DES?qualifyHint=False> and <xref:System.Security.Cryptography.Rijndael?qualifyHint=False>.  
  
### To create the encryption wrapper  
  
1.  Create the `Simple3Des` class to encapsulate the encryption and decryption methods.  
  
     [!code[VbVbalrStrings#38](../vs140/codesnippet/VisualBasic/walkthrough--encrypting-and-decrypting-strings-in-visual-basic_1.vb)]
  
  
2.  Add an import of the cryptography namespace to the start of the file that contains the `Simple3Des` class.  
  
     [!code[VbVbalrStrings#77](../vs140/codesnippet/VisualBasic/walkthrough--encrypting-and-decrypting-strings-in-visual-basic_2.vb)]
  
  
3.  In the `Simple3Des` class, add a private field to store the 3DES cryptographic service provider.  
  
     [!code[VbVbalrStrings#39](../vs140/codesnippet/VisualBasic/walkthrough--encrypting-and-decrypting-strings-in-visual-basic_3.vb)]
  
  
4.  Add a private method that creates a byte array of a specified length from the hash of the specified key.  
  
     [!code[VbVbalrStrings#41](../vs140/codesnippet/VisualBasic/walkthrough--encrypting-and-decrypting-strings-in-visual-basic_4.vb)]
  
  
5.  Add a constructor to initialize the 3DES cryptographic service provider.  
  
     The `key` parameter controls the `EncryptData` and `DecryptData` methods.  
  
     [!code[VbVbalrStrings#40](../vs140/codesnippet/VisualBasic/walkthrough--encrypting-and-decrypting-strings-in-visual-basic_5.vb)]
  
  
6.  Add a public method that encrypts a string.  
  
     [!code[VbVbalrStrings#42](../vs140/codesnippet/VisualBasic/walkthrough--encrypting-and-decrypting-strings-in-visual-basic_6.vb)]
  
  
7.  Add a public method that decrypts a string.  
  
     [!code[VbVbalrStrings#43](../vs140/codesnippet/VisualBasic/walkthrough--encrypting-and-decrypting-strings-in-visual-basic_7.vb)]
  
  
     The wrapper class can now be used to protect user assets. In this example, it is used to securely store private user data in a publicly accessible text file.  
  
### To test the encryption wrapper  
  
1.  In a separate class, add a method that uses the wrapper's `EncryptData` method to encrypt a string and write it to the user's My Documents folder.  
  
     [!code[VbVbalrStrings#78](../vs140/codesnippet/VisualBasic/walkthrough--encrypting-and-decrypting-strings-in-visual-basic_8.vb)]
  
  
2.  Add a method that reads the encrypted string from the user's My Documents folder and decrypts the string with the wrapper's `DecryptData` method.  
  
     [!code[VbVbalrStrings#79](../vs140/codesnippet/VisualBasic/walkthrough--encrypting-and-decrypting-strings-in-visual-basic_9.vb)]
  
  
3.  Add user interface code to call the `TestEncoding` and `TestDecoding` methods.  
  
4.  Run the application.  
  
     When you test the application, notice that it will not decrypt the data if you provide the wrong password.  
  
## See Also  
 <xref:System.Security.Cryptography?qualifyHint=False>   
 <xref:System.Security.Cryptography.DESCryptoServiceProvider?qualifyHint=False>   
 <xref:System.Security.Cryptography.DES?qualifyHint=False>   
 <xref:System.Security.Cryptography.TripleDES?qualifyHint=False>   
 <xref:System.Security.Cryptography.Rijndael?qualifyHint=False>   
 [Cryptography Overview](assetId:///f96284bc-7b73-44b5-ac59-fac613ad09f8)