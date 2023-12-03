import { TestBed, inject } from "@angular/core/testing";
import { DevMagicService } from "./dev-magic.service";
import { Devmagic } from "./devmagic";

describe("DevMagicService", () => {
  let service: DevMagicService;

  // beforeEach(() => {
  //   TestBed.configureTestingModule({
  //     providers: [DevMagicService],
  //   });
  //   service = TestBed.inject(DevMagicService);
  // });

  // it("should be created", () => {
  //   expect(service).toBeTruthy();
  // });

  // it("should return Devmagic data", async () => {
  //   const mockData: Devmagic = {
  //     /* mock your expected data structure here */
  //   };

  //   spyOn(window, "fetch").and.returnValue(
  //     Promise.resolve({
  //       text: () => Promise.resolve(JSON.stringify(mockData)),
  //     } as Response)
  //   );

  //   const result = await service.getDevmagic();

  //   expect(result).toEqual(mockData);
  // });
});
