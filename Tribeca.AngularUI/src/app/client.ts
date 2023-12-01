export interface Client {
  clientId: number;
  name: string;
  offices: Office[];
}

export interface Office {
  officeId: number;
  address: string;
  isHeadOffice: boolean;
  employeeId: number;
  employeeName: string;
}
