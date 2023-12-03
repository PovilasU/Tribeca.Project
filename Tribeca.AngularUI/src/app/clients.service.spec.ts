import { TestBed } from "@angular/core/testing";
import { ClientsService } from "./clients.service";
import { Client, Office } from "./client";
import { of } from "rxjs";

describe("ClientsService", () => {
  let service: ClientsService;
  let clientsService: ClientsService;
  let httpClientSpy: { get: jasmine.Spy };

  beforeEach(() => {
    httpClientSpy = jasmine.createSpyObj("HttpClient", ["get"]);

    TestBed.configureTestingModule({
      providers: [ClientsService],
    });

    clientsService = TestBed.inject(ClientsService);
  });

  it("should be created", () => {
    expect(clientsService).toBeTruthy();
  });

  it("should return an array of clients", (done) => {
    const mockClients: Client[] = [
      {
        clientId: 1,
        name: "Client A",
        offices: [
          {
            officeId: 3,
            address: "11 Spooner Road",
            isHeadOffice: true,
            employeeId: 3,
            employeeName: "Peter Fisher",
          },
          {
            officeId: 1,
            address: "123 Street",
            isHeadOffice: false,
            employeeId: 1,
            employeeName: "Sam Fisher",
          },
          {
            officeId: 2,
            address: "66 Road",
            isHeadOffice: false,
            employeeId: 2,
            employeeName: "John Fisher",
          },
        ],
      },
      // Add more clients as needed
    ];

    httpClientSpy.get.and.returnValue(of(mockClients));

    clientsService.getAllClients().then((clients) => {
      expect(clients[0]).toEqual(mockClients[0]);
      done();
    });
  });
});
