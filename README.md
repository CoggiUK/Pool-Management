# Pool Management
| **Module**          | **Method** | **Endpoint**                           | **Mô tả chức năng**                | **Xác thực** |
| ------------------- | ---------- | -------------------------------------- | ---------------------------------- | ------------ |
| 🔐 Auth             | POST       | `/api/auth/login`                      | Đăng nhập                          | ❌            |
|                     | POST       | `/api/auth/logout`                     | Đăng xuất                          | ✅            |
|                     | GET        | `/api/auth/profile`                    | Lấy thông tin người dùng đăng nhập | ✅            |
|                     | POST       | `/api/auth/refresh-token`              | Làm mới token                      | ✅            |
| Roles & Permissions | GET        | `/api/roles`                           | Lấy danh sách vai trò              | ✅            |
|                     | POST       | `/api/roles`                           | Thêm vai trò                       | ✅            |
|                     | PUT        | `/api/roles/{id}`                      | Cập nhật vai trò                   | ✅            |
|                     | DELETE     | `/api/roles/{id}`                      | Xóa vai trò (xóa mềm)              | ✅            |
| 👨‍💼 Employees        | GET        | `/api/employees`                       | Lấy danh sách nhân viên            | ✅            |
|                     | GET        | `/api/employees/{id}`                  | Xem chi tiết nhân viên             | ✅            |
|                     | POST       | `/api/employees`                       | Tạo nhân viên                      | ✅            |
|                     | PUT        | `/api/employees/{id}`                  | Cập nhật nhân viên                 | ✅            |
|                     | DELETE     | `/api/employees/{id}`                  | Xóa mềm nhân viên                  | ✅            |
| 👥 Customers        | GET        | `/api/customers`                       | Lấy danh sách khách hàng           | ✅            |
|                     | GET        | `/api/customers/{id}`                  | Chi tiết khách hàng                | ✅            |
|                     | POST       | `/api/customers`                       | Thêm khách hàng mới                | ✅            |
|                     | PUT        | `/api/customers/{id}`                  | Cập nhật thông tin khách hàng      | ✅            |
|                     | DELETE     | `/api/customers/{id}`                  | Xóa khách hàng (mềm)               | ✅            |
| 🏊 Pools            | GET        | `/api/pools`                           | Danh sách bể bơi                   | ✅            |
|                     | GET        | `/api/pools/{id}`                      | Chi tiết bể bơi                    | ✅            |
|                     | POST       | `/api/pools`                           | Thêm bể bơi                        | ✅            |
|                     | PUT        | `/api/pools/{id}`                      | Cập nhật bể bơi                    | ✅            |
|                     | DELETE     | `/api/pools/{id}`                      | Xóa mềm bể bơi                     | ✅            |
| ⚙️ Devices          | GET        | `/api/devices`                         | Danh sách thiết bị                 | ✅            |
|                     | GET        | `/api/devices/{id}`                    | Chi tiết thiết bị                  | ✅            |
|                     | POST       | `/api/devices`                         | Thêm thiết bị                      | ✅            |
|                     | PUT        | `/api/devices/{id}`                    | Cập nhật thiết bị                  | ✅            |
|                     | DELETE     | `/api/devices/{id}`                    | Xóa thiết bị (mềm)                 | ✅            |
| 📦 Service Packages | GET        | `/api/packages`                        | Danh sách gói dịch vụ              | ✅            |
|                     | GET        | `/api/packages/{id}`                   | Chi tiết gói                       | ✅            |
|                     | POST       | `/api/packages`                        | Thêm gói dịch vụ                   | ✅            |
|                     | PUT        | `/api/packages/{id}`                   | Cập nhật gói                       | ✅            |
|                     | DELETE     | `/api/packages/{id}`                   | Xóa gói dịch vụ                    | ✅            |
|                     | POST       | `/api/customers/{id}/register-package` | Khách đăng ký gói                  | ✅            |
| 📅 Bookings         | GET        | `/api/bookings`                        | Danh sách đặt chỗ                  | ✅            |
|                     | GET        | `/api/bookings/{id}`                   | Chi tiết đặt chỗ                   | ✅            |
|                     | POST       | `/api/bookings`                        | Tạo đặt chỗ                        | ✅            |
|                     | PUT        | `/api/bookings/{id}`                   | Cập nhật đặt chỗ                   | ✅            |
|                     | DELETE     | `/api/bookings/{id}`                   | Hủy đặt chỗ (mềm)                  | ✅            |
|                     | GET        | `/api/pools/{id}/available-times`      | Lấy khung giờ trống của bể bơi     | ✅            |
| 💳 Invoices         | GET        | `/api/invoices`                        | Danh sách hóa đơn                  | ✅            |
|                     | GET        | `/api/invoices/{id}`                   | Chi tiết hóa đơn                   | ✅            |
|                     | POST       | `/api/invoices`                        | Tạo hóa đơn                        | ✅            |
|                     | PUT        | `/api/invoices/{id}`                   | Cập nhật hóa đơn                   | ✅            |
|                     | DELETE     | `/api/invoices/{id}`                   | Xóa hóa đơn (mềm)                  | ✅            |
|                     | POST       | `/api/invoices/{id}/pay`               | Thanh toán hóa đơn                 | ✅            |
| 🔧 Maintenance      | GET        | `/api/maintenance`                     | Danh sách lịch bảo trì             | ✅            |
|                     | POST       | `/api/maintenance`                     | Thêm lịch bảo trì                  | ✅            |
|                     | PUT        | `/api/maintenance/{id}`                | Cập nhật bảo trì                   | ✅            |
|                     | DELETE     | `/api/maintenance/{id}`                | Xóa bảo trì (mềm)                  | ✅            |
|                     | POST       | `/api/devices/{id}/report-issue`       | Báo lỗi thiết bị                   | ✅            |
| 📊 Reports          | GET        | `/api/reports/booking-summary`         | Tổng quan đặt chỗ                  | ✅            |
|                     | GET        | `/api/reports/customer-growth`         | Tăng trưởng khách hàng             | ✅            |
|                     | GET        | `/api/reports/employee-attendance`     | Báo cáo công nhân viên             | ✅            |
|                     | GET        | `/api/reports/revenue`                 | Doanh thu                          | ✅            |
|                     | GET        | `/api/reports/device-usage`            | Sử dụng thiết bị                   | ✅            |
