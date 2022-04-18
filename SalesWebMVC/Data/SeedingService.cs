using SalesWebMVC.Models;
using SalesWebMVC.Models.Enums;
using System;
using System.Linq;

namespace SalesWebMVC.Data
{
    public class SeedingService
    {
        private SalesWebMVCContext _context;

        public SeedingService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return; // DB has been seeded
            }

            Department dept1 = new Department(1, "Computers");
            Department dept2 = new Department(2, "Electronics");
            Department dept3 = new Department(3, "Fashion");
            Department dept4 = new Department(4, "Books");

            Seller seller1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, dept1);
            Seller seller2 = new Seller(2, "Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.0, dept2);
            Seller seller3 = new Seller(3, "Alex Grey", "alex@gmail.com", new DateTime(1988, 1, 15), 2200.0, dept1);
            Seller seller4 = new Seller(4, "Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 3000.0, dept4);
            Seller seller5 = new Seller(5, "Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 4000.0, dept3);
            Seller seller6 = new Seller(6, "Alex Pink", "bob@gmail.com", new DateTime(1997, 3, 4), 3000.0, dept2);

            SalesRecord rec1 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0, SalesStatus.Billed, seller1);
            SalesRecord rec2 = new SalesRecord(2, new DateTime(2018, 09, 4), 7000.0, SalesStatus.Billed, seller5);
            SalesRecord rec3 = new SalesRecord(3, new DateTime(2018, 09, 13), 4000.0, SalesStatus.Canceled, seller4);
            SalesRecord rec4 = new SalesRecord(4, new DateTime(2018, 09, 1), 8000.0, SalesStatus.Billed, seller1);
            SalesRecord rec5 = new SalesRecord(5, new DateTime(2018, 09, 21), 3000.0, SalesStatus.Billed, seller3);
            SalesRecord rec6 = new SalesRecord(6, new DateTime(2018, 09, 15), 2000.0, SalesStatus.Billed, seller1);
            SalesRecord rec7 = new SalesRecord(7, new DateTime(2018, 09, 28), 13000.0, SalesStatus.Billed, seller2);
            SalesRecord rec8 = new SalesRecord(8, new DateTime(2018, 09, 11), 4000.0, SalesStatus.Billed, seller4);
            SalesRecord rec9 = new SalesRecord(9, new DateTime(2018, 09, 14), 11000.0, SalesStatus.Pending, seller6);
            SalesRecord rec10 = new SalesRecord(10, new DateTime(2018, 09, 7), 9000.0, SalesStatus.Billed, seller6);
            SalesRecord rec11 = new SalesRecord(11, new DateTime(2018, 09, 13), 6000.0, SalesStatus.Billed, seller2);
            SalesRecord rec12 = new SalesRecord(12, new DateTime(2018, 09, 25), 7000.0, SalesStatus.Pending, seller3);
            SalesRecord rec13 = new SalesRecord(13, new DateTime(2018, 09, 29), 10000.0, SalesStatus.Billed, seller4);
            SalesRecord rec14 = new SalesRecord(14, new DateTime(2018, 09, 4), 3000.0, SalesStatus.Billed, seller5);
            SalesRecord rec15 = new SalesRecord(15, new DateTime(2018, 09, 12), 4000.0, SalesStatus.Billed, seller1);
            SalesRecord rec16 = new SalesRecord(16, new DateTime(2018, 10, 5), 2000.0, SalesStatus.Billed, seller4);
            SalesRecord rec17 = new SalesRecord(17, new DateTime(2018, 10, 1), 12000.0, SalesStatus.Billed, seller1);
            SalesRecord rec18 = new SalesRecord(18, new DateTime(2018, 10, 24), 6000.0, SalesStatus.Billed, seller3);
            SalesRecord rec19 = new SalesRecord(19, new DateTime(2018, 10, 22), 8000.0, SalesStatus.Billed, seller5);
            SalesRecord rec20 = new SalesRecord(20, new DateTime(2018, 10, 15), 8000.0, SalesStatus.Billed, seller6);
            SalesRecord rec21 = new SalesRecord(21, new DateTime(2018, 10, 17), 9000.0, SalesStatus.Billed, seller2);
            SalesRecord rec22 = new SalesRecord(22, new DateTime(2018, 10, 24), 4000.0, SalesStatus.Billed, seller4);
            SalesRecord rec23 = new SalesRecord(23, new DateTime(2018, 10, 19), 11000.0, SalesStatus.Canceled, seller2);
            SalesRecord rec24 = new SalesRecord(24, new DateTime(2018, 10, 12), 8000.0, SalesStatus.Billed, seller5);
            SalesRecord rec25 = new SalesRecord(25, new DateTime(2018, 10, 31), 7000.0, SalesStatus.Billed, seller3);
            SalesRecord rec26 = new SalesRecord(26, new DateTime(2018, 10, 6), 5000.0, SalesStatus.Billed, seller4);
            SalesRecord rec27 = new SalesRecord(27, new DateTime(2018, 10, 13), 9000.0, SalesStatus.Pending, seller1);
            SalesRecord rec28 = new SalesRecord(28, new DateTime(2018, 10, 7), 4000.0, SalesStatus.Billed, seller3);
            SalesRecord rec29 = new SalesRecord(29, new DateTime(2018, 10, 23), 12000.0, SalesStatus.Billed, seller5);
            SalesRecord rec30 = new SalesRecord(30, new DateTime(2018, 10, 12), 5000.0, SalesStatus.Billed, seller2);

            _context.Department.AddRange(dept1, dept2, dept3, dept4);

            _context.Seller.AddRange(seller1, seller2, seller3, seller4, seller5, seller6);

            _context.SalesRecord.AddRange(
                rec1, rec2, rec3, rec4, rec5, rec6, rec7, rec8, rec9, rec10,
                rec11, rec12, rec13, rec14, rec15, rec16, rec17, rec18, rec19, rec20,
                rec21, rec22, rec23, rec24, rec25, rec26, rec27, rec28, rec29, rec30
            );

            _context.SaveChanges();
        }
    }
}
