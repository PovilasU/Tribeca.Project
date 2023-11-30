// export interface Client {
//   clientId: number;
//   officeID: number;
//   address: string;
//   isHeadOffice: boolean;
//   name: string;
//   employeeID: number;
//   employeeName: string;
// }
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
