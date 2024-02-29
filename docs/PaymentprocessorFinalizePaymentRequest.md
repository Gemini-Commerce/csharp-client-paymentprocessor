# # PaymentprocessorFinalizePaymentRequest


## Properties 


Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TenantId**| **string** |   |
**PaymentId**| **string** |   |
**Context**| [**PaymentprocessorPaymentContext**](PaymentprocessorPaymentContext.md) |   | [optional]
**Code**| **string** | payment type stripe, paypal..  |
**Amount**| [**PaymentprocessorMoney**](PaymentprocessorMoney.md) |   | [optional]
**Currency**| **PaymentprocessorCurrency** |  for more information please, see Model/PaymentprocessorCurrency.php  | [optional]
**AdditionalInfo**| **string** |   | [optional]
**Transactions**| [**List<PaymentprocessorTransaction>**](PaymentprocessorTransaction.md) |   | [optional]


[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)

