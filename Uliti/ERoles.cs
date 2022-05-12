namespace FastFood.Uliti
{
    public enum ERoles
    {
        Member,
        Mod,
        Admin,

    }
    public enum EOrderStatus
    {
        Pending,
        Aprove,
        Cancel
    }
    public enum EUserStatus
    {
        Pending,
        Active,
        Block
    }
    public enum EOrderType
    {
        PAYMENT_COD,
        PAYMENT_MOMO,
        PAYMENT_BANK
    }
}
