export interface CustomersType {
	customerID: string;
	companyName: string;
	contactName: string;
	contactTitle: string;
	address: AddressType;
}

export interface AddressType {
	street: string;
	city: string;
	region: string;
	postalCode: string;
	country: string;
	phone: string;
}
