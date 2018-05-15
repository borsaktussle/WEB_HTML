<!-- Ini HEADER -->
<?php include 'header.php'; ?>;
<!-- Ini SIDEBAR -->
<?php include 'sidebar.php'; ?>; 


  <!-- Content Wrapper. Contains page content -->
  <div class="content-wrapper">
    <!-- Content Header (Page header) -->
    <section class="content-header">
      <div class="container-fluid">
        <div class="row mb-2">
          <div class="col-sm-6">
          </div>
          <div class="col-sm-6">
            <ol class="breadcrumb float-sm-right">
              <li class="breadcrumb-item"><a href="#">Home</a></li>
              <li class="breadcrumb-item active">Status</li>
            </ol>
          </div>
        </div>
      </div><!-- /.container-fluid -->
    </section>

    <!-- Main content -->
    <section class="content">
      <div class="row">
        <div class="col-12">
          <div class="card">
            <div class="card-header">
              <h3 class="card-title">Status</h3>
            </div>
            
          </div>
          <!-- /.card -->
          
          <div class="card">
           <div>
            <a href="#" class="btn btn-success">
                      <i class="fa fa-plus"></i> Tambah Status
                  </a>
            </div>
            <!-- /.card-header -->
            <div class="card-body">
              
              <table id="example1" class="table table-bordered table-striped">
                <thead>
                <tr align="center">
                  <th>No</th>
                  <th>ID Status</th>
                  <th>Nama Status</th>
                </tr>
                </thead>
                <tbody>

                <tr>
                  <td>1</td>
                  <td>1</td>
                  <td>Aktif</td>
                </tr>
                <tr>
                  <td>2</td>
                  <td>2</td>
                  <td>Banned</td>
                </tr>
                <tr>
                  <td>3</td>
                  <td>3</td>
                  <td>Banned Permanen</td>
                </tr>
                </tbody>
              </table>
            </div>
            <!-- /.card-body -->
          </div>
          <!-- /.card -->
        </div>
        <!-- /.col -->
      </div>
      <!-- /.row -->
    </section>
    <!-- /.content -->
  </div>
  <!-- /.content-wrapper -->

<!-- ./wrapper -->

 <!-- Ini FOOTER -->
 <?php include 'footer.php'; ?>; 