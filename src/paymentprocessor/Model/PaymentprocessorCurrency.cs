/*
 * Payment Processor Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Contact: info@gemini-commerce.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = paymentprocessor.Client.OpenAPIDateConverter;

namespace paymentprocessor.Model
{
    /// <summary>
    /// Stands for Albania, not all ;-)
    /// </summary>
    /// <value>Stands for Albania, not all ;-)</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaymentprocessorCurrency
    {
        /// <summary>
        /// Enum XXX for value: XXX
        /// </summary>
        [EnumMember(Value = "XXX")]
        XXX = 1,

        /// <summary>
        /// Enum ALL for value: ALL
        /// </summary>
        [EnumMember(Value = "ALL")]
        ALL = 2,

        /// <summary>
        /// Enum DZD for value: DZD
        /// </summary>
        [EnumMember(Value = "DZD")]
        DZD = 3,

        /// <summary>
        /// Enum ARS for value: ARS
        /// </summary>
        [EnumMember(Value = "ARS")]
        ARS = 4,

        /// <summary>
        /// Enum AUD for value: AUD
        /// </summary>
        [EnumMember(Value = "AUD")]
        AUD = 5,

        /// <summary>
        /// Enum BSD for value: BSD
        /// </summary>
        [EnumMember(Value = "BSD")]
        BSD = 6,

        /// <summary>
        /// Enum BHD for value: BHD
        /// </summary>
        [EnumMember(Value = "BHD")]
        BHD = 7,

        /// <summary>
        /// Enum BDT for value: BDT
        /// </summary>
        [EnumMember(Value = "BDT")]
        BDT = 8,

        /// <summary>
        /// Enum AMD for value: AMD
        /// </summary>
        [EnumMember(Value = "AMD")]
        AMD = 9,

        /// <summary>
        /// Enum BBD for value: BBD
        /// </summary>
        [EnumMember(Value = "BBD")]
        BBD = 10,

        /// <summary>
        /// Enum BMD for value: BMD
        /// </summary>
        [EnumMember(Value = "BMD")]
        BMD = 11,

        /// <summary>
        /// Enum BTN for value: BTN
        /// </summary>
        [EnumMember(Value = "BTN")]
        BTN = 12,

        /// <summary>
        /// Enum BOB for value: BOB
        /// </summary>
        [EnumMember(Value = "BOB")]
        BOB = 13,

        /// <summary>
        /// Enum BWP for value: BWP
        /// </summary>
        [EnumMember(Value = "BWP")]
        BWP = 14,

        /// <summary>
        /// Enum BZD for value: BZD
        /// </summary>
        [EnumMember(Value = "BZD")]
        BZD = 15,

        /// <summary>
        /// Enum SBD for value: SBD
        /// </summary>
        [EnumMember(Value = "SBD")]
        SBD = 16,

        /// <summary>
        /// Enum BND for value: BND
        /// </summary>
        [EnumMember(Value = "BND")]
        BND = 17,

        /// <summary>
        /// Enum MMK for value: MMK
        /// </summary>
        [EnumMember(Value = "MMK")]
        MMK = 18,

        /// <summary>
        /// Enum BIF for value: BIF
        /// </summary>
        [EnumMember(Value = "BIF")]
        BIF = 19,

        /// <summary>
        /// Enum KHR for value: KHR
        /// </summary>
        [EnumMember(Value = "KHR")]
        KHR = 20,

        /// <summary>
        /// Enum CAD for value: CAD
        /// </summary>
        [EnumMember(Value = "CAD")]
        CAD = 21,

        /// <summary>
        /// Enum CVE for value: CVE
        /// </summary>
        [EnumMember(Value = "CVE")]
        CVE = 22,

        /// <summary>
        /// Enum KYD for value: KYD
        /// </summary>
        [EnumMember(Value = "KYD")]
        KYD = 23,

        /// <summary>
        /// Enum LKR for value: LKR
        /// </summary>
        [EnumMember(Value = "LKR")]
        LKR = 24,

        /// <summary>
        /// Enum CLP for value: CLP
        /// </summary>
        [EnumMember(Value = "CLP")]
        CLP = 25,

        /// <summary>
        /// Enum CNY for value: CNY
        /// </summary>
        [EnumMember(Value = "CNY")]
        CNY = 26,

        /// <summary>
        /// Enum COP for value: COP
        /// </summary>
        [EnumMember(Value = "COP")]
        COP = 27,

        /// <summary>
        /// Enum KMF for value: KMF
        /// </summary>
        [EnumMember(Value = "KMF")]
        KMF = 28,

        /// <summary>
        /// Enum CRC for value: CRC
        /// </summary>
        [EnumMember(Value = "CRC")]
        CRC = 29,

        /// <summary>
        /// Enum HRK for value: HRK
        /// </summary>
        [EnumMember(Value = "HRK")]
        HRK = 30,

        /// <summary>
        /// Enum CUP for value: CUP
        /// </summary>
        [EnumMember(Value = "CUP")]
        CUP = 31,

        /// <summary>
        /// Enum CZK for value: CZK
        /// </summary>
        [EnumMember(Value = "CZK")]
        CZK = 32,

        /// <summary>
        /// Enum DKK for value: DKK
        /// </summary>
        [EnumMember(Value = "DKK")]
        DKK = 33,

        /// <summary>
        /// Enum DOP for value: DOP
        /// </summary>
        [EnumMember(Value = "DOP")]
        DOP = 34,

        /// <summary>
        /// Enum SVC for value: SVC
        /// </summary>
        [EnumMember(Value = "SVC")]
        SVC = 35,

        /// <summary>
        /// Enum ETB for value: ETB
        /// </summary>
        [EnumMember(Value = "ETB")]
        ETB = 36,

        /// <summary>
        /// Enum ERN for value: ERN
        /// </summary>
        [EnumMember(Value = "ERN")]
        ERN = 37,

        /// <summary>
        /// Enum FKP for value: FKP
        /// </summary>
        [EnumMember(Value = "FKP")]
        FKP = 38,

        /// <summary>
        /// Enum FJD for value: FJD
        /// </summary>
        [EnumMember(Value = "FJD")]
        FJD = 39,

        /// <summary>
        /// Enum DJF for value: DJF
        /// </summary>
        [EnumMember(Value = "DJF")]
        DJF = 40,

        /// <summary>
        /// Enum GMD for value: GMD
        /// </summary>
        [EnumMember(Value = "GMD")]
        GMD = 41,

        /// <summary>
        /// Enum GIP for value: GIP
        /// </summary>
        [EnumMember(Value = "GIP")]
        GIP = 42,

        /// <summary>
        /// Enum GTQ for value: GTQ
        /// </summary>
        [EnumMember(Value = "GTQ")]
        GTQ = 43,

        /// <summary>
        /// Enum GNF for value: GNF
        /// </summary>
        [EnumMember(Value = "GNF")]
        GNF = 44,

        /// <summary>
        /// Enum GYD for value: GYD
        /// </summary>
        [EnumMember(Value = "GYD")]
        GYD = 45,

        /// <summary>
        /// Enum HTG for value: HTG
        /// </summary>
        [EnumMember(Value = "HTG")]
        HTG = 46,

        /// <summary>
        /// Enum HNL for value: HNL
        /// </summary>
        [EnumMember(Value = "HNL")]
        HNL = 47,

        /// <summary>
        /// Enum HKD for value: HKD
        /// </summary>
        [EnumMember(Value = "HKD")]
        HKD = 48,

        /// <summary>
        /// Enum HUF for value: HUF
        /// </summary>
        [EnumMember(Value = "HUF")]
        HUF = 49,

        /// <summary>
        /// Enum ISK for value: ISK
        /// </summary>
        [EnumMember(Value = "ISK")]
        ISK = 50,

        /// <summary>
        /// Enum INR for value: INR
        /// </summary>
        [EnumMember(Value = "INR")]
        INR = 51,

        /// <summary>
        /// Enum IDR for value: IDR
        /// </summary>
        [EnumMember(Value = "IDR")]
        IDR = 52,

        /// <summary>
        /// Enum IRR for value: IRR
        /// </summary>
        [EnumMember(Value = "IRR")]
        IRR = 53,

        /// <summary>
        /// Enum IQD for value: IQD
        /// </summary>
        [EnumMember(Value = "IQD")]
        IQD = 54,

        /// <summary>
        /// Enum ILS for value: ILS
        /// </summary>
        [EnumMember(Value = "ILS")]
        ILS = 55,

        /// <summary>
        /// Enum JMD for value: JMD
        /// </summary>
        [EnumMember(Value = "JMD")]
        JMD = 56,

        /// <summary>
        /// Enum JPY for value: JPY
        /// </summary>
        [EnumMember(Value = "JPY")]
        JPY = 57,

        /// <summary>
        /// Enum KZT for value: KZT
        /// </summary>
        [EnumMember(Value = "KZT")]
        KZT = 58,

        /// <summary>
        /// Enum JOD for value: JOD
        /// </summary>
        [EnumMember(Value = "JOD")]
        JOD = 59,

        /// <summary>
        /// Enum KES for value: KES
        /// </summary>
        [EnumMember(Value = "KES")]
        KES = 60,

        /// <summary>
        /// Enum KPW for value: KPW
        /// </summary>
        [EnumMember(Value = "KPW")]
        KPW = 61,

        /// <summary>
        /// Enum KRW for value: KRW
        /// </summary>
        [EnumMember(Value = "KRW")]
        KRW = 62,

        /// <summary>
        /// Enum KWD for value: KWD
        /// </summary>
        [EnumMember(Value = "KWD")]
        KWD = 63,

        /// <summary>
        /// Enum KGS for value: KGS
        /// </summary>
        [EnumMember(Value = "KGS")]
        KGS = 64,

        /// <summary>
        /// Enum LAK for value: LAK
        /// </summary>
        [EnumMember(Value = "LAK")]
        LAK = 65,

        /// <summary>
        /// Enum LBP for value: LBP
        /// </summary>
        [EnumMember(Value = "LBP")]
        LBP = 66,

        /// <summary>
        /// Enum LSL for value: LSL
        /// </summary>
        [EnumMember(Value = "LSL")]
        LSL = 67,

        /// <summary>
        /// Enum LRD for value: LRD
        /// </summary>
        [EnumMember(Value = "LRD")]
        LRD = 68,

        /// <summary>
        /// Enum LYD for value: LYD
        /// </summary>
        [EnumMember(Value = "LYD")]
        LYD = 69,

        /// <summary>
        /// Enum LTL for value: LTL
        /// </summary>
        [EnumMember(Value = "LTL")]
        LTL = 70,

        /// <summary>
        /// Enum MOP for value: MOP
        /// </summary>
        [EnumMember(Value = "MOP")]
        MOP = 71,

        /// <summary>
        /// Enum MWK for value: MWK
        /// </summary>
        [EnumMember(Value = "MWK")]
        MWK = 72,

        /// <summary>
        /// Enum MYR for value: MYR
        /// </summary>
        [EnumMember(Value = "MYR")]
        MYR = 73,

        /// <summary>
        /// Enum MVR for value: MVR
        /// </summary>
        [EnumMember(Value = "MVR")]
        MVR = 74,

        /// <summary>
        /// Enum MRO for value: MRO
        /// </summary>
        [EnumMember(Value = "MRO")]
        MRO = 75,

        /// <summary>
        /// Enum MUR for value: MUR
        /// </summary>
        [EnumMember(Value = "MUR")]
        MUR = 76,

        /// <summary>
        /// Enum MXN for value: MXN
        /// </summary>
        [EnumMember(Value = "MXN")]
        MXN = 77,

        /// <summary>
        /// Enum MNT for value: MNT
        /// </summary>
        [EnumMember(Value = "MNT")]
        MNT = 78,

        /// <summary>
        /// Enum MDL for value: MDL
        /// </summary>
        [EnumMember(Value = "MDL")]
        MDL = 79,

        /// <summary>
        /// Enum MAD for value: MAD
        /// </summary>
        [EnumMember(Value = "MAD")]
        MAD = 80,

        /// <summary>
        /// Enum OMR for value: OMR
        /// </summary>
        [EnumMember(Value = "OMR")]
        OMR = 81,

        /// <summary>
        /// Enum NAD for value: NAD
        /// </summary>
        [EnumMember(Value = "NAD")]
        NAD = 82,

        /// <summary>
        /// Enum NPR for value: NPR
        /// </summary>
        [EnumMember(Value = "NPR")]
        NPR = 83,

        /// <summary>
        /// Enum ANG for value: ANG
        /// </summary>
        [EnumMember(Value = "ANG")]
        ANG = 84,

        /// <summary>
        /// Enum AWG for value: AWG
        /// </summary>
        [EnumMember(Value = "AWG")]
        AWG = 85,

        /// <summary>
        /// Enum VUV for value: VUV
        /// </summary>
        [EnumMember(Value = "VUV")]
        VUV = 86,

        /// <summary>
        /// Enum NZD for value: NZD
        /// </summary>
        [EnumMember(Value = "NZD")]
        NZD = 87,

        /// <summary>
        /// Enum NIO for value: NIO
        /// </summary>
        [EnumMember(Value = "NIO")]
        NIO = 88,

        /// <summary>
        /// Enum NGN for value: NGN
        /// </summary>
        [EnumMember(Value = "NGN")]
        NGN = 89,

        /// <summary>
        /// Enum NOK for value: NOK
        /// </summary>
        [EnumMember(Value = "NOK")]
        NOK = 90,

        /// <summary>
        /// Enum PKR for value: PKR
        /// </summary>
        [EnumMember(Value = "PKR")]
        PKR = 91,

        /// <summary>
        /// Enum PAB for value: PAB
        /// </summary>
        [EnumMember(Value = "PAB")]
        PAB = 92,

        /// <summary>
        /// Enum PGK for value: PGK
        /// </summary>
        [EnumMember(Value = "PGK")]
        PGK = 93,

        /// <summary>
        /// Enum PYG for value: PYG
        /// </summary>
        [EnumMember(Value = "PYG")]
        PYG = 94,

        /// <summary>
        /// Enum PEN for value: PEN
        /// </summary>
        [EnumMember(Value = "PEN")]
        PEN = 95,

        /// <summary>
        /// Enum PHP for value: PHP
        /// </summary>
        [EnumMember(Value = "PHP")]
        PHP = 96,

        /// <summary>
        /// Enum QAR for value: QAR
        /// </summary>
        [EnumMember(Value = "QAR")]
        QAR = 97,

        /// <summary>
        /// Enum RUB for value: RUB
        /// </summary>
        [EnumMember(Value = "RUB")]
        RUB = 98,

        /// <summary>
        /// Enum RWF for value: RWF
        /// </summary>
        [EnumMember(Value = "RWF")]
        RWF = 99,

        /// <summary>
        /// Enum SHP for value: SHP
        /// </summary>
        [EnumMember(Value = "SHP")]
        SHP = 100,

        /// <summary>
        /// Enum STD for value: STD
        /// </summary>
        [EnumMember(Value = "STD")]
        STD = 101,

        /// <summary>
        /// Enum SAR for value: SAR
        /// </summary>
        [EnumMember(Value = "SAR")]
        SAR = 102,

        /// <summary>
        /// Enum SCR for value: SCR
        /// </summary>
        [EnumMember(Value = "SCR")]
        SCR = 103,

        /// <summary>
        /// Enum SLL for value: SLL
        /// </summary>
        [EnumMember(Value = "SLL")]
        SLL = 104,

        /// <summary>
        /// Enum SGD for value: SGD
        /// </summary>
        [EnumMember(Value = "SGD")]
        SGD = 105,

        /// <summary>
        /// Enum VND for value: VND
        /// </summary>
        [EnumMember(Value = "VND")]
        VND = 106,

        /// <summary>
        /// Enum SOS for value: SOS
        /// </summary>
        [EnumMember(Value = "SOS")]
        SOS = 107,

        /// <summary>
        /// Enum ZAR for value: ZAR
        /// </summary>
        [EnumMember(Value = "ZAR")]
        ZAR = 108,

        /// <summary>
        /// Enum SSP for value: SSP
        /// </summary>
        [EnumMember(Value = "SSP")]
        SSP = 109,

        /// <summary>
        /// Enum SZL for value: SZL
        /// </summary>
        [EnumMember(Value = "SZL")]
        SZL = 110,

        /// <summary>
        /// Enum SEK for value: SEK
        /// </summary>
        [EnumMember(Value = "SEK")]
        SEK = 111,

        /// <summary>
        /// Enum CHF for value: CHF
        /// </summary>
        [EnumMember(Value = "CHF")]
        CHF = 112,

        /// <summary>
        /// Enum SYP for value: SYP
        /// </summary>
        [EnumMember(Value = "SYP")]
        SYP = 113,

        /// <summary>
        /// Enum THB for value: THB
        /// </summary>
        [EnumMember(Value = "THB")]
        THB = 114,

        /// <summary>
        /// Enum TOP for value: TOP
        /// </summary>
        [EnumMember(Value = "TOP")]
        TOP = 115,

        /// <summary>
        /// Enum TTD for value: TTD
        /// </summary>
        [EnumMember(Value = "TTD")]
        TTD = 116,

        /// <summary>
        /// Enum AED for value: AED
        /// </summary>
        [EnumMember(Value = "AED")]
        AED = 117,

        /// <summary>
        /// Enum TND for value: TND
        /// </summary>
        [EnumMember(Value = "TND")]
        TND = 118,

        /// <summary>
        /// Enum UGX for value: UGX
        /// </summary>
        [EnumMember(Value = "UGX")]
        UGX = 119,

        /// <summary>
        /// Enum MKD for value: MKD
        /// </summary>
        [EnumMember(Value = "MKD")]
        MKD = 120,

        /// <summary>
        /// Enum EGP for value: EGP
        /// </summary>
        [EnumMember(Value = "EGP")]
        EGP = 121,

        /// <summary>
        /// Enum GBP for value: GBP
        /// </summary>
        [EnumMember(Value = "GBP")]
        GBP = 122,

        /// <summary>
        /// Enum TZS for value: TZS
        /// </summary>
        [EnumMember(Value = "TZS")]
        TZS = 123,

        /// <summary>
        /// Enum USD for value: USD
        /// </summary>
        [EnumMember(Value = "USD")]
        USD = 124,

        /// <summary>
        /// Enum UYU for value: UYU
        /// </summary>
        [EnumMember(Value = "UYU")]
        UYU = 125,

        /// <summary>
        /// Enum UZS for value: UZS
        /// </summary>
        [EnumMember(Value = "UZS")]
        UZS = 126,

        /// <summary>
        /// Enum WST for value: WST
        /// </summary>
        [EnumMember(Value = "WST")]
        WST = 127,

        /// <summary>
        /// Enum YER for value: YER
        /// </summary>
        [EnumMember(Value = "YER")]
        YER = 128,

        /// <summary>
        /// Enum TWD for value: TWD
        /// </summary>
        [EnumMember(Value = "TWD")]
        TWD = 129,

        /// <summary>
        /// Enum CUC for value: CUC
        /// </summary>
        [EnumMember(Value = "CUC")]
        CUC = 130,

        /// <summary>
        /// Enum ZWL for value: ZWL
        /// </summary>
        [EnumMember(Value = "ZWL")]
        ZWL = 131,

        /// <summary>
        /// Enum TMT for value: TMT
        /// </summary>
        [EnumMember(Value = "TMT")]
        TMT = 132,

        /// <summary>
        /// Enum GHS for value: GHS
        /// </summary>
        [EnumMember(Value = "GHS")]
        GHS = 133,

        /// <summary>
        /// Enum VEF for value: VEF
        /// </summary>
        [EnumMember(Value = "VEF")]
        VEF = 134,

        /// <summary>
        /// Enum SDG for value: SDG
        /// </summary>
        [EnumMember(Value = "SDG")]
        SDG = 135,

        /// <summary>
        /// Enum UYI for value: UYI
        /// </summary>
        [EnumMember(Value = "UYI")]
        UYI = 136,

        /// <summary>
        /// Enum RSD for value: RSD
        /// </summary>
        [EnumMember(Value = "RSD")]
        RSD = 137,

        /// <summary>
        /// Enum MZN for value: MZN
        /// </summary>
        [EnumMember(Value = "MZN")]
        MZN = 138,

        /// <summary>
        /// Enum AZN for value: AZN
        /// </summary>
        [EnumMember(Value = "AZN")]
        AZN = 139,

        /// <summary>
        /// Enum RON for value: RON
        /// </summary>
        [EnumMember(Value = "RON")]
        RON = 140,

        /// <summary>
        /// Enum CHE for value: CHE
        /// </summary>
        [EnumMember(Value = "CHE")]
        CHE = 141,

        /// <summary>
        /// Enum CHW for value: CHW
        /// </summary>
        [EnumMember(Value = "CHW")]
        CHW = 142,

        /// <summary>
        /// Enum TRY for value: TRY
        /// </summary>
        [EnumMember(Value = "TRY")]
        TRY = 143,

        /// <summary>
        /// Enum XAF for value: XAF
        /// </summary>
        [EnumMember(Value = "XAF")]
        XAF = 144,

        /// <summary>
        /// Enum XCD for value: XCD
        /// </summary>
        [EnumMember(Value = "XCD")]
        XCD = 145,

        /// <summary>
        /// Enum XOF for value: XOF
        /// </summary>
        [EnumMember(Value = "XOF")]
        XOF = 146,

        /// <summary>
        /// Enum XPF for value: XPF
        /// </summary>
        [EnumMember(Value = "XPF")]
        XPF = 147,

        /// <summary>
        /// Enum XBA for value: XBA
        /// </summary>
        [EnumMember(Value = "XBA")]
        XBA = 148,

        /// <summary>
        /// Enum XBB for value: XBB
        /// </summary>
        [EnumMember(Value = "XBB")]
        XBB = 149,

        /// <summary>
        /// Enum XBC for value: XBC
        /// </summary>
        [EnumMember(Value = "XBC")]
        XBC = 150,

        /// <summary>
        /// Enum XBD for value: XBD
        /// </summary>
        [EnumMember(Value = "XBD")]
        XBD = 151,

        /// <summary>
        /// Enum XAU for value: XAU
        /// </summary>
        [EnumMember(Value = "XAU")]
        XAU = 152,

        /// <summary>
        /// Enum XDR for value: XDR
        /// </summary>
        [EnumMember(Value = "XDR")]
        XDR = 153,

        /// <summary>
        /// Enum XAG for value: XAG
        /// </summary>
        [EnumMember(Value = "XAG")]
        XAG = 154,

        /// <summary>
        /// Enum XPT for value: XPT
        /// </summary>
        [EnumMember(Value = "XPT")]
        XPT = 155,

        /// <summary>
        /// Enum XPD for value: XPD
        /// </summary>
        [EnumMember(Value = "XPD")]
        XPD = 156,

        /// <summary>
        /// Enum XUA for value: XUA
        /// </summary>
        [EnumMember(Value = "XUA")]
        XUA = 157,

        /// <summary>
        /// Enum ZMW for value: ZMW
        /// </summary>
        [EnumMember(Value = "ZMW")]
        ZMW = 158,

        /// <summary>
        /// Enum SRD for value: SRD
        /// </summary>
        [EnumMember(Value = "SRD")]
        SRD = 159,

        /// <summary>
        /// Enum MGA for value: MGA
        /// </summary>
        [EnumMember(Value = "MGA")]
        MGA = 160,

        /// <summary>
        /// Enum COU for value: COU
        /// </summary>
        [EnumMember(Value = "COU")]
        COU = 161,

        /// <summary>
        /// Enum AFN for value: AFN
        /// </summary>
        [EnumMember(Value = "AFN")]
        AFN = 162,

        /// <summary>
        /// Enum TJS for value: TJS
        /// </summary>
        [EnumMember(Value = "TJS")]
        TJS = 163,

        /// <summary>
        /// Enum AOA for value: AOA
        /// </summary>
        [EnumMember(Value = "AOA")]
        AOA = 164,

        /// <summary>
        /// Enum BYR for value: BYR
        /// </summary>
        [EnumMember(Value = "BYR")]
        BYR = 165,

        /// <summary>
        /// Enum BGN for value: BGN
        /// </summary>
        [EnumMember(Value = "BGN")]
        BGN = 166,

        /// <summary>
        /// Enum CDF for value: CDF
        /// </summary>
        [EnumMember(Value = "CDF")]
        CDF = 167,

        /// <summary>
        /// Enum BAM for value: BAM
        /// </summary>
        [EnumMember(Value = "BAM")]
        BAM = 168,

        /// <summary>
        /// Enum EUR for value: EUR
        /// </summary>
        [EnumMember(Value = "EUR")]
        EUR = 169,

        /// <summary>
        /// Enum MXV for value: MXV
        /// </summary>
        [EnumMember(Value = "MXV")]
        MXV = 170,

        /// <summary>
        /// Enum UAH for value: UAH
        /// </summary>
        [EnumMember(Value = "UAH")]
        UAH = 171,

        /// <summary>
        /// Enum GEL for value: GEL
        /// </summary>
        [EnumMember(Value = "GEL")]
        GEL = 172,

        /// <summary>
        /// Enum BOV for value: BOV
        /// </summary>
        [EnumMember(Value = "BOV")]
        BOV = 173,

        /// <summary>
        /// Enum PLN for value: PLN
        /// </summary>
        [EnumMember(Value = "PLN")]
        PLN = 174,

        /// <summary>
        /// Enum BRL for value: BRL
        /// </summary>
        [EnumMember(Value = "BRL")]
        BRL = 175,

        /// <summary>
        /// Enum CLF for value: CLF
        /// </summary>
        [EnumMember(Value = "CLF")]
        CLF = 176,

        /// <summary>
        /// Enum XSU for value: XSU
        /// </summary>
        [EnumMember(Value = "XSU")]
        XSU = 177,

        /// <summary>
        /// Enum USN for value: USN
        /// </summary>
        [EnumMember(Value = "USN")]
        USN = 178
    }

}
